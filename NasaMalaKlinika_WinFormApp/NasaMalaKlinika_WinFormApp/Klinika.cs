using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaOrdinacija;

namespace NasaMalaKlinika
{
    public static class Klinika
    {
        public static List<Pacijent> pacijenti = new List<Pacijent>();
        public static List<Ordinacija> ordinacije = new List<Ordinacija> {
            new Ordinacija("Kardiološki pregled", 600),
            new Ordinacija("Dermatološki pregled", 450),
            new Ordinacija("Ortopedski pregled", 390),
            new Ordinacija("Internistički pregled", 710),
            new Ordinacija("Otorinolaringološki pregled", 480),
            new Ordinacija("Oftamološki pregled", 185),
            new Ordinacija("Laboratorijski pregled", 720),
            new Ordinacija("Stomatološki pregled", 540),
            new Ordinacija("Opšti pregled", 300)
        };
        public static List<Uposlenik> uposlenici = new List<Uposlenik>();
        private static decimal ukupnaZarada = 0;

        /*public Klinika()
        {
            pacijenti = new List<Pacijent>();
            ordinacije = new List<Ordinacija>();
            uposlenici = new List<Uposlenik>();
        }
        public Klinika(List<Pacijent> p, List<Ordinacija> o, List<Uposlenik> u)
        {
            pacijenti = new List<Pacijent>(p);
            ordinacije = new List<Ordinacija>(o);
            uposlenici = new List<Uposlenik>(u);
        }
        public Klinika(List<Ordinacija> o, List<Uposlenik> u)
        {
            pacijenti = new List<Pacijent>();
            ordinacije = new List<Ordinacija>(o);
            uposlenici = new List<Uposlenik>(u);
        }*/
        public static void RegistrirajPacijenta(Pacijent p)
        {
            pacijenti.Add(p);
        }
        public static void RegistrirajUposlenog(Uposlenik u)
        {
            uposlenici.Add(u);
        }
        public static List<Pacijent> DajPacijenteSaImenom(string ime)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            foreach(Pacijent pacijent in pacijenti)
            {
                if(pacijent.ime == ime)
                {
                    pacijenti.Add(pacijent);
                }
            }
            return pacijenti;
        }
        public static List<Pacijent> DajPacijenteSaPrezimenom(string prezime)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            foreach (Pacijent pacijent in pacijenti)
            {
                if (pacijent.prezime == prezime)
                {
                    pacijenti.Add(pacijent);
                }
            }
            return pacijenti;
        }
        public static List<Pacijent> DajPacijenteSaImenomPrezimenom(string punoIme)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            foreach (Pacijent pacijent in pacijenti)
            {
                if (pacijent.DajPunoIme() == punoIme)
                {
                    pacijenti.Add(pacijent);
                }
            }
            return pacijenti;
        }
        public static void PoveziDoktoraSaOrdinacijom(Ordinacija ordinacija, Doktor doktor)
        {
            if (ordinacija.doktor == null)
            {
                ordinacija.doktor = doktor;
            }
            else
            {
                throw new Exception("Ordinacija vec ima doktora!");
            }
        }
        public static Pacijent DajPacijentaSaJMBG(string jmbg)
        {
            return pacijenti.Find(p => p.maticniBroj == jmbg);
        }
        public static Pacijent DajPacijentaSaId(Int64 id)
        {
            Pacijent p = pacijenti.Find(x => x.idPacijenta == id);
            if (p == null)
                throw new Exception("Ne postoji pacijent sa tim id");
            return p;
        }
        public static void IzbrisiPacijenta(Pacijent p)
        {
            pacijenti.Remove(p);
        }
        public static void PrikaziPregledePacijenta(Pacijent p)
        {
            p.zakazaniPregledi.Sort((x, y) => x.ordinacija.listaCekanja.Count().CompareTo(y.ordinacija.listaCekanja.Count()));
            Console.WriteLine(p.PrikaziZakazanePreglede());
        }
        public static string PrikaziKartonPacijenta(int id)
        {
            Pacijent p = DajPacijentaSaId(id);
            if (p.karton == null)
                throw new Exception("Pacijent nema kreiran karton");
            return p.ToString();
        }
        public static void RegistrirajNoviPregled(Pacijent pacijent, Ordinacija ordinacija, Pregled pregled)
        {
            if(pacijent is PacijentSmrtniIshod)
                throw new Exception("Pacijent je nazalost preminuo, ne mozete registrirati pregled");
            pacijent.ZakaziPregled(pregled);
            ordinacija.StaviUListuCekanja(pacijent);
        }
        public static void RegistrirajNoviKarton(int id, Karton k)
        {
            Pacijent p = DajPacijentaSaId(id);
            if (p is PacijentSmrtniIshod)
                throw new Exception("Pacijent je nazalost preminuo, ne mozete kreirati karton");
            if (p.karton == null)
                p.karton = k;
            else
                throw new Exception("Pacijent vec ima kreiran karton");
        }
        public static decimal ObracunajPacijenta(Pacijent pacijent, List<Pregled> preglediKojePlaca, int brojRata)
        {
            if (preglediKojePlaca.Count == 0)
                throw new Exception("Pacijent nije obavio nijedan pregled");
            decimal iznosNaplate = pacijent.IznosNaplate(brojRata);
            ukupnaZarada += iznosNaplate;
            return iznosNaplate;
        }
        public static string ProcenatPacijenataPoGodinama()
        {
            int brIspodOsamnaest = pacijenti.Count(x => x.datumRođenja.AddYears(18) > DateTime.Now);
            int brOsamnaestDoTrideset = pacijenti.Count(x => x.datumRođenja.AddYears(18) <= DateTime.Now && x.datumRođenja.AddYears(30) > DateTime.Now);
            int brTridesetDoPedeset = pacijenti.Count(x => x.datumRođenja.AddYears(30) <= DateTime.Now && x.datumRođenja.AddYears(50) > DateTime.Now);
            int brPrekoPedeset = pacijenti.Count(x => x.datumRođenja.AddYears(50) <= DateTime.Now);
            string s = "Broj registriranih pacijenata\n";
            s += "-ispod 18 godina: " + Math.Round(Convert.ToDouble(brIspodOsamnaest) * 100 / pacijenti.Count(), 2) + "%\n";
            s += "-između 18 i 30 godina: " + Math.Round(Convert.ToDouble(brOsamnaestDoTrideset) * 100 / pacijenti.Count(), 2) + "%\n";
            s += "-između 30 i 50 godina: " + Math.Round(Convert.ToDouble(brTridesetDoPedeset) * 100 / pacijenti.Count(), 2) + "%\n";
            s += "-preko 50 godina: " + Math.Round(Convert.ToDouble(brPrekoPedeset) * 100 / pacijenti.Count(), 2) + "%\n";
            return s; 
        }   

        public static List<int> _IntProcenatPacijenataPoGodinama()
        {
            List<int> procenti = new List<int>();
            procenti.Add(pacijenti.Count(x => x.datumRođenja.AddYears(18) > DateTime.Now));
            procenti.Add(pacijenti.Count(x => x.datumRođenja.AddYears(18) <= DateTime.Now && x.datumRođenja.AddYears(30) > DateTime.Now));
            procenti.Add(pacijenti.Count(x => x.datumRođenja.AddYears(30) <= DateTime.Now && x.datumRođenja.AddYears(50) > DateTime.Now));
            procenti.Add(pacijenti.Count(x => x.datumRođenja.AddYears(50) <= DateTime.Now));
            return procenti;
        }

        public static string NajposjecenijeOrdinacije()
        {
            var ord = ordinacije.OrderByDescending(x => x.doktor.brojPacijenata).ToList();
            string s = "";
            s += "1. " + ord.ElementAt(0).tipPregleda + " - " + "broj posjeta: " + Convert.ToString(ord.ElementAt(0).doktor.brojPacijenata) + "\n";
            s += "2. " + ord.ElementAt(1).tipPregleda + " - " + "broj posjeta: " + Convert.ToString(ord.ElementAt(1).doktor.brojPacijenata) + "\n";
            s += "3. " + ord.ElementAt(2).tipPregleda + " - " + "broj posjeta: " + Convert.ToString(ord.ElementAt(2).doktor.brojPacijenata) + "\n";
            return s;
        }
        public static string IzvjestajZarada()
        {
            return "Klinika je ukupno zaradila " + ukupnaZarada + " KM.";
        } 
    }
}

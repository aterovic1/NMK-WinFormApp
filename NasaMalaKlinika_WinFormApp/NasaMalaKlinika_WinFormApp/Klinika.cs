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
            new Ordinacija("Kardioloski pregled", 600),
            new Ordinacija("Dermatoloski pregled", 450),
            new Ordinacija("Ortopedski pregled", 390),
            new Ordinacija("Internisticki pregled", 710),
            new Ordinacija("Otorinolaringoloski pregled", 480),
            new Ordinacija("Oftamoloski pregled", 185),
            new Ordinacija("Laboratorijski pregled", 720),
            new Ordinacija("Stomatoloski pregled", 540),
            new Ordinacija("Opsti pregled", 300)
        };

        public static List<Uposlenik> uposlenici = new List<Uposlenik> {

        new Doktor("Meho", "Karabeg", Convert.ToDateTime("05.12.1975."), "0512975114528", "Behdzeta Mutevelica 56", Spol.musko, "Oženjen", 3500, "mkarabeg", "pass"),
        new Doktor("Almir", "Kardovic", Convert.ToDateTime("15.08.1989."), "1508989147854", "Zmaja od Bosne 24", Spol.musko, "Neoženjen", 3000, "akardovic", "pass"),
        new Doktor("Ena", "Hodzic", Convert.ToDateTime("07.12.1987."), "0712987452369", "Aleja Bosne srebrene 47", Spol.zensko, "Razvedena", 2700, "ehodzic", "pass"),
        new Doktor("Alma", "Masic", Convert.ToDateTime("12.01.1965."), "1201965211478", "Safeta Zajke 158", Spol.zensko, "Udata", 1900, "mkarabeg", "amasic"),
        new Doktor("Arnes", "Sehovic", Convert.ToDateTime("21.07.1970."), "2107970856654", "Alibega Firdusa 77", Spol.musko, "Razveden", 2350, "asehovic", "pass"),
        new Doktor("Irma", "Dedovic", Convert.ToDateTime("29.06.1979."), "2906979147521", "Paromlinska 63", Spol.zensko, "Udata", 4100, "mkarabeg", "idedovic"),
        new Doktor("Asim", "Omerovic", Convert.ToDateTime("01.11.1984."), "0111984663281", "Nedima Filipovica 12", Spol.musko, "neoženjen", 3560, "aomerovic", "pass"),
        new Doktor("Lejla", "Durakovic", Convert.ToDateTime("10.03.1976."), "1003976541219", "Avdage Sahinagica 19", Spol.zensko, "Udovica", 2180, "ldurakovic", "pass"),
        new Doktor("Osman", "Kustura", Convert.ToDateTime("14.02.1969."), "1402969365241", "Kasindolska 147", Spol.musko, "Oženjen", 3250, "okustura", "pass")
        };


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
        public static Pacijent DajPacijentaSaImenom(string ime, string prezime)
        {
            return pacijenti.Find(p => p.ime == ime && p.prezime == prezime);
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
            if (pacijenti.Exists(x => x.idPacijenta == p.idPacijenta))
                pacijenti.Remove(p);
            else
                throw new Exception("Ne postoji taj pacijent");
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
        public static string NajposjecenijeOrdinacije()
        {
            var ord = ordinacije.OrderByDescending(x => x.doktor.brojPacijenata).ToList();
            string s = "Najposjecenije ordinacije:\n";
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

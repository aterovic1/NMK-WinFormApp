﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaOrdinacija;

namespace NasaMalaKlinika
{
    public class Klinika
    { 
        public List<Pacijent> pacijenti;
        public List<Ordinacija> ordinacije;
        public List<Uposlenik> uposlenici;
        private decimal ukupnaZarada;

        public Klinika()
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
        }
        public void RegistrirajPacijenta(Pacijent p)
        {
            pacijenti.Add(p);
        }
        public Pacijent DajPacijentaSaImenom(string ime, string prezime)
        {
            return pacijenti.Find(p => p.ime == ime && p.prezime == prezime);
        }
        public Pacijent DajPacijentaSaJMBG(string jmbg)
        {
            return pacijenti.Find(p => p.maticniBroj == jmbg);
        }
        public Pacijent DajPacijentaSaId(Int64 id)
        {
            Pacijent p = pacijenti.Find(x => x.idPacijenta == id);
            if (p == null)
                throw new Exception("Ne postoji pacijent sa tim id");
            return p;
        }
        public void IzbrisiPacijenta(Pacijent p)
        {
            if (pacijenti.Exists(x => x.idPacijenta == p.idPacijenta))
                pacijenti.Remove(p);
            else
                throw new Exception("Ne postoji taj pacijent");
        }
        public void PrikaziPregledePacijenta(Pacijent p)
        {
            p.zakazaniPregledi.Sort((x, y) => x.ordinacija.listaCekanja.Count().CompareTo(y.ordinacija.listaCekanja.Count()));
            Console.WriteLine(p.PrikaziZakazanePreglede());
        }
        public string PrikaziKartonPacijenta(int id)
        {
            Pacijent p = DajPacijentaSaId(id);
            if (p.karton == null)
                throw new Exception("Pacijent nema kreiran karton");
            return p.ToString();
        }
        public void RegistrirajNoviPregled(Pacijent pacijent, Ordinacija ordinacija, Pregled pregled)
        {
            if(pacijent is PacijentSmrtniIshod)
                throw new Exception("Pacijent je nazalost preminuo, ne mozete registrirati pregled");
            pacijent.ZakaziPregled(pregled);
            ordinacija.StaviUListuCekanja(pacijent);
        }
        public void RegistrirajNoviKarton(int id, Karton k)
        {
            Pacijent p = DajPacijentaSaId(id);
            if (p is PacijentSmrtniIshod)
                throw new Exception("Pacijent je nazalost preminuo, ne mozete kreirati karton");
            if (p.karton == null)
                p.karton = k;
            else
                throw new Exception("Pacijent vec ima kreiran karton");
        }
        public decimal ObracunajPacijenta(Pacijent pacijent, List<Pregled> preglediKojePlaca, int brojRata)
        {
            if (preglediKojePlaca.Count == 0)
                throw new Exception("Pacijent nije obavio nijedan pregled");
            decimal iznosNaplate = pacijent.IznosNaplate(brojRata);
            ukupnaZarada += iznosNaplate;
            return iznosNaplate;
        }
        public string ProcenatPacijenataPoGodinama()
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
        public string NajposjecenijeOrdinacije()
        {
            var ord = ordinacije.OrderByDescending(x => x.doktor.brojPacijenata).ToList();
            string s = "Najposjecenije ordinacije:\n";
            s += "1. " + ord.ElementAt(0).tipPregleda + " - " + "broj posjeta: " + Convert.ToString(ord.ElementAt(0).doktor.brojPacijenata) + "\n";
            s += "2. " + ord.ElementAt(1).tipPregleda + " - " + "broj posjeta: " + Convert.ToString(ord.ElementAt(1).doktor.brojPacijenata) + "\n";
            s += "3. " + ord.ElementAt(2).tipPregleda + " - " + "broj posjeta: " + Convert.ToString(ord.ElementAt(2).doktor.brojPacijenata) + "\n";
            return s;
        }
        public string IzvjestajZarada()
        {
            return "Klinika je ukupno zaradila " + ukupnaZarada + " KM.";
        } 
    }
}

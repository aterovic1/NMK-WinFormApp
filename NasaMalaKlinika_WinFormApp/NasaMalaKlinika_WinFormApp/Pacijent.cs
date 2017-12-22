using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaOrdinacija;
using System.Drawing;

namespace NasaMalaKlinika
{
    public partial class Pacijent : Osoba
    {
        private static Int64 PACIJENT_ID = 100;

        public Int64 idPacijenta { get; private set; }
        public Karton karton { get; set; }
        public List<Pregled> zakazaniPregledi { get; set; }
        public Image slika;

        public Pacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt, Image slika) :
            base(ime, pre, rod, jmbg, adr, spol, brSt)
        {
            this.idPacijenta = PACIJENT_ID;
            PACIJENT_ID++;
            this.karton = null;
            this.zakazaniPregledi = new List<Pregled>();
            this.slika = slika;
        }
        public Pacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt, Karton karton, List<Pregled> zakazani) :
            base(ime, pre, rod, jmbg, adr, spol, brSt)
        {
            this.idPacijenta = PACIJENT_ID;
            PACIJENT_ID++;
            this.karton = null;
            this.zakazaniPregledi = new List<Pregled>(zakazani);
            this.karton = karton;
        }
        public override string ToString()
        {
            return base.ToString() + karton.ToString();
        }
        public void ZakaziPregled(Pregled p)
        {
            zakazaniPregledi.Add(p);
        }
        public string PrikaziZakazanePreglede()
        {
            string s = "";
            zakazaniPregledi.ForEach(x => s += x.ToString());
            if (s.Length == 0)
                s = "Pacijent nema zakazanih pregleda";
            return s;
        }
        public Pregled DajPregledSaId(int id)
        {
            Pregled p = zakazaniPregledi.Find(x => x.IdPregleda == id);
            if (p == null)
                throw new Exception("Ne postoji pregled sa ovim id");
            return p;
        }
        public void ObaviPregled(DateTime dat, string rez, string ter, Pregled p, Ordinacija o)
        {
            if (karton == null)
                throw new Exception("Pacijent nema kreiran karton");
            o.IzbaciIzListeCekanja();
            zakazaniPregledi.Remove(p);
            p.AzurirajPregled(dat, rez, ter);
            karton.DodajPregled(p);
            p.ordinacija.doktor.DodajPacijentaUBrojPregleda();
        }
        public string PrikaziObavljenePregledeSaCijenom()
        {
            string s = "";
            karton.obavljeniPregledi.ForEach(x => s += x.ordinacija.tipPregleda + ", " + x.datumPregleda.ToString("d") + "\nCijena pregleda: " + x.ordinacija.cijenaPregleda + " KM\n");
            return s;
        } 
    }
}

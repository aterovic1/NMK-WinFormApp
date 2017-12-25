using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaOrdinacija;
using System.Drawing;
using System.Security.Cryptography;

namespace NasaMalaKlinika
{
    public partial class Pacijent : Osoba
    {
        private static Int64 PACIJENT_ID = 100;

        public Int64 idPacijenta { get; private set; }
        public Karton karton { get; set; }
        public List<Pregled> zakazaniPregledi { get; set; }
        public string username;
        public string password { get; private set; }
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
        public Pacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt) :
            base(ime, pre, rod, jmbg, adr, spol, brSt)
        {
            this.idPacijenta = PACIJENT_ID;
            PACIJENT_ID++;
            this.karton = null;
            this.zakazaniPregledi = new List<Pregled>();
        }
        public Pacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt, Karton karton, List<Pregled> zakazani, string username, string password) :
            base(ime, pre, rod, jmbg, adr, spol, brSt)
        {
            this.idPacijenta = PACIJENT_ID;
            PACIJENT_ID++;
            this.karton = null;
            this.zakazaniPregledi = new List<Pregled>(zakazani);
            this.karton = karton;
            foreach(Pregled pregled in zakazani)
            {
                pregled.ordinacija.StaviUListuCekanja(this);
            }
            this.username = username;
            this.password = IzracunajMD5Hash(password);
        }
        public override string ToString()
        {
            return base.ToString() + karton.ToString();
        }
        public void ZakaziPregled(Pregled p)
        {
            zakazaniPregledi.Add(p);
            p.ordinacija.StaviUListuCekanja(this);
        }
        public string PrikaziZakazanePreglede()
        {
            string s = "";
            zakazaniPregledi.ForEach(x => s += x.ToString() + "\n");
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
            karton.obavljeniPregledi.ForEach(x => s += x.ToString() + "Cijena pregleda: " + x.ordinacija.cijenaPregleda + " KM\n\n");
            return s;
        } 
        public string DajPunoImeSaID()
        {
            return idPacijenta.ToString() + " " + ime + " " + prezime;
        }
        public string DajPregledeUOrdinaciji(Ordinacija ordinacija)
        {
            string pregledi = "";
            foreach(Pregled pregled in karton.obavljeniPregledi)
            {
                if(pregled.ordinacija.Equals(ordinacija))
                {
                    pregledi += pregled.DajDetaljePregleda();
                }
            }
            return pregledi;
        }
        public string IzracunajMD5Hash(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] ulaz = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(ulaz);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public decimal DajDugPacijenta()
        {
            decimal dug = 0;
            karton.obavljeniPregledi.ForEach(x => dug += x.ordinacija.cijenaPregleda);
            return dug;
        }
    }
}

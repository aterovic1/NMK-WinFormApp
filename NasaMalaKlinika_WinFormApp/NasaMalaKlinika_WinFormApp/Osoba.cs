using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public enum Spol { musko, zensko };

    public abstract class Osoba
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRođenja { get; set; }
        public string maticniBroj { get; set; }
        public Spol spol { get; set; }
        public string adresa { get; set; }
        public string bracnoStanje { get; set; }

        public Osoba(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt)
        {
            if (jmbg.Length != 13)
                throw new Exception("Neispravan JMBG");
            this.ime = ime;
            this.prezime = pre;
            this.datumRođenja = rod;
            this.maticniBroj = jmbg;
            this.spol = spol;
            this.adresa = adr;
            this.bracnoStanje = brSt;
        }
        public override string ToString()
        {
            string s = "";
            s += "Pacijent: " + ime + " " + prezime + "\n";
            s += "Datum rođenja: " + datumRođenja.ToString("d") + "\n";
            s += "Matični broj: " + maticniBroj + "\n";
            s += "Spol: " + spol.ToString() + "\n";
            s += "Adresa: " + adresa + "\n";
            s += "Bracno stanje: " + bracnoStanje.ToString() + "\n\n";
            return s;
        }
    }
}

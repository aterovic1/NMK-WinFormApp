using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaOrdinacija;

namespace NasaMalaKlinika
{
    public class Pregled
    {
        private static Int64 PREGLED_ID = 1000;

        private Int64 idPregleda;
        public DateTime datumPregleda { get; set; }
        public Ordinacija ordinacija { get; set; }
        public bool obavljen { get; set; }
        public string rezultat { get; set; }
        public string terapija { get; set; }

        public long IdPregleda
        {
            get
            {
                return IdPregleda;
            }
        }
        public Pregled(Ordinacija ord)
        {
            idPregleda = PREGLED_ID;
            PREGLED_ID++;
            this.ordinacija = ord;
            this.obavljen = false;
            this.rezultat = "";
            this.terapija = "";
        }
        public override string ToString()
        {
            string s = "";
            s += (obavljen == true) ? "Pregled obavljen: " + datumPregleda.ToString("d") + "\n" : "";
            s += (obavljen == true) ? "Rezultat: " + rezultat + "\n" : "";
            s += (obavljen == true) ? "Terapija: " + terapija + "\n" : "";
            s += (obavljen == true) ? "Pregled obavio doktor " : "Pregled zakazan kod doktora ";
            s += ordinacija.doktor.ime + " " + ordinacija.doktor.prezime + ", ordinacija za " + ordinacija.tipPregleda + "\n\n";
            return s;
        }
        public void AzurirajPregled(DateTime dat, string rez, string ter)
        {
            this.datumPregleda = dat;
            this.terapija = ter;
            this.rezultat = rez;
            this.obavljen = true;
        } 
    }
}

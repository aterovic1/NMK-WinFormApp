using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public sealed class PacijentSmrtniIshod : HitniPacijent
    {
        public DateTime vrijemeSmrti { get; set; }
        public string uzrokSmrti { get; set; }

        public PacijentSmrtniIshod(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt, string prvaPom, DateTime vrijemeSmrti, string uzrokSmrti, Image slika) : base(ime, pre, rod, jmbg, adr, spol, brSt, prvaPom, slika)
        {
            this.vrijemeSmrti = vrijemeSmrti;
            this.uzrokSmrti = uzrokSmrti;
        }
        public override string ToString()
        {
            string s = "Vrijeme smrti: " + Convert.ToString(vrijemeSmrti.Hour, vrijemeSmrti.Minute) + "\n";
            s += "Uzrok smrti: " + uzrokSmrti + "\n";
            return base.ToString() + s;
        }
    }
}

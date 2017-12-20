using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public class HitniPacijent : Pacijent
    {
        public string prvaPomoc { get; set; }

        public HitniPacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, BracnoStanje brSt, string prvaPom) :
            base(ime, pre, rod, jmbg, adr, spol, brSt)
        {
            this.prvaPomoc = prvaPom;
        }
        public HitniPacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, BracnoStanje brSt, Karton karton, List<Pregled> zakazani, string prvaPom) :
            base(ime, pre, rod, jmbg, adr, spol, brSt, karton, zakazani)
        {
            this.prvaPomoc = prvaPom;
        }
        public override string ToString()
        {
            string s = "Pacijentu je pruzena prva pomoc: " + prvaPomoc + " prilikom dolaska na kliniku\n";
            return s + base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public class HitniPacijent : Pacijent
    {
        public string prvaPomoc { get; set; }

        public HitniPacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt, Karton karton, List<Pregled> zakazani, string prvaPomoc, string username, string password) :
            base(ime, pre, rod, jmbg, adr, spol, brSt, karton, zakazani, username, password)
        {
            this.prvaPomoc = prvaPomoc;
        }
        public HitniPacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt, List<Pregled> zakazani, string username, string password, Image image, string prvaPom) :
            base(ime, pre, rod, jmbg, adr, spol, brSt, zakazani, username, password, image)
        {
            this.prvaPomoc = prvaPom;
        }
        public HitniPacijent(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt, string prvaPom) :
            base(ime, pre, rod, jmbg, adr, spol, brSt)
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

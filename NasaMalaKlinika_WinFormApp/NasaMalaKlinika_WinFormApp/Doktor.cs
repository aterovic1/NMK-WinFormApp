using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public class Doktor : Uposlenik
    {
        public int brojPacijenata { get; set; }
        static double bonus = 0.1;

        public Doktor(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, string brSt, decimal plata, string username, string password) :
            base(ime, pre, rod, jmbg, adr, spol, brSt, plata, username, password)
        {
            this.brojPacijenata = 0;
        }
        public override decimal DajPlatu()
        {
            return base.DajPlatu() + brojPacijenata * Convert.ToDecimal(bonus) * Plata;
        }
        public void DodajPacijentaUBrojPregleda()
        {
            brojPacijenata++;
        }
    }
}

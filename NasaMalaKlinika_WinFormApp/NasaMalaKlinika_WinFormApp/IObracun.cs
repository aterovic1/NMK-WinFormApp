using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public interface IObracun
    {
        decimal IznosNaplate(int brojRata);
    }
    
    public partial class Pacijent : IObracun
    {
        public virtual decimal IznosNaplate(int brojRata = 1)
        {
            decimal naplata = 0;
            karton.obavljeniPregledi.ForEach(x => naplata += x.ordinacija.cijenaPregleda);
            if (karton.obavljeniPregledi.Count() > 3 && brojRata == 1)
            {
                naplata = Convert.ToDecimal(0.9) * naplata;
            }
            else if (karton.obavljeniPregledi.Count() <= 3 && brojRata > 1)
            {
                naplata = Convert.ToDecimal(1.15) * naplata;
            }
            return naplata;
        }
    } 
}

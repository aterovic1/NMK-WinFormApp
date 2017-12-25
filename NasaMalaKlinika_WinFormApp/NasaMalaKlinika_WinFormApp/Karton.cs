using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public class Karton
    { 
        public List<Pregled> obavljeniPregledi;
        //anamneza
        public string alergije;
        public string ranijeBolesti;
        public string zdravStanjeUPorodici;

        public Karton(string a, string rb, string zdS)
        {
            this.obavljeniPregledi = new List<Pregled>();
            this.alergije = a;
            this.ranijeBolesti = rb;
            this.zdravStanjeUPorodici = zdS;
        }
        public string DajPreglede()
        {
            string s = "";
            obavljeniPregledi.ForEach(p => s += p.ToString());
            return s;
        }
        public void DodajPregled(Pregled p)
        {
            obavljeniPregledi.Add(p);
        }
        public int DajBrojPregleda()
        {
            return obavljeniPregledi.Count();
        }
        public override string ToString()
        {
            string s = "";
            s += "Ranije bolesti: " + ranijeBolesti + "\n";
            s += "Alergije: " + alergije + "\n";
            s += "Zdravstveno stanje u porodici: " + zdravStanjeUPorodici + "\n\n";
            if (DajBrojPregleda() == 0) {
                s += "Pacijent nije obavio nijedan pregled\n";
            }
            else {
                s += "Pacijent je obavio sljedece preglede:\n\n";
                obavljeniPregledi.ForEach(x => s += x.ordinacija.tipPregleda + "\n" + x.ToString());
            }
            return s;
        } 
        public string DajAnamnezu()
        {
            string s = "";
            s += "Ranije bolesti: " + ranijeBolesti + "\n";
            s += "Alergije: " + alergije + "\n";
            s += "Zdravstveno stanje u porodici: " + zdravStanjeUPorodici;
            return s;
        }
    }
}

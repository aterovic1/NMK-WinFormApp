using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NasaMalaKlinika;

namespace KlinikaOrdinacija
{
    public class Ordinacija
    {
        public string tipPregleda { get; set; }
        public Doktor doktor { get; set; }
        public bool zauzetAparat { get; set; }
        public decimal cijenaPregleda { get; set; }
        public List<Pacijent> listaCekanja { get; set; }

        public Ordinacija(string n, Doktor doc, decimal c)
        {
            this.tipPregleda = n;
            this.doktor = doc;
            this.zauzetAparat = false;
            this.cijenaPregleda = c;
            this.listaCekanja = new List<Pacijent>();
        }
        public void StaviUListuCekanja(Pacijent p)
        {
            listaCekanja.Add(p);
        }
        public string PrikaziListuCekanja()
        {
            string s = "";
            if (listaCekanja.Count != 0)
                listaCekanja.ForEach(x => s += x.ime + " " + x.prezime + "\n");
            else
                throw new Exception("Lista cekanja je prazna");
            return s;
        }
        public void IzbaciIzListeCekanja()
        {
            listaCekanja.Remove(listaCekanja.First());
        }
    }
}

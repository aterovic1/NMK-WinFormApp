using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NasaMalaKlinika
{
    public class Uposlenik : Osoba
    {
        private decimal plata;
        public string username;
        public string password;

        public Uposlenik(string ime, string pre, DateTime rod, string jmbg, string adr, Spol spol, BracnoStanje brSt, decimal plata, string username, string password) :
            base(ime, pre, rod, jmbg, adr, spol, brSt)
        {
            this.Plata = plata;
            this.password = IzracunajMD5Hash(password);
            this.username = username;
        }

        public decimal Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
            }
        }
        public virtual decimal DajPlatu()
        {
            return this.Plata;
        } 
        public string IzracunajMD5Hash(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] ulaz = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(ulaz);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}

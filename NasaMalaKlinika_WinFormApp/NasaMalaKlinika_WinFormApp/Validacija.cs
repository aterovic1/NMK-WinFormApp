using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaMalaKlinika_WinFormApp
{
    static class Validacija
    {
        public static bool ValidirajImeIPrezime(string ime)
        {
            Regex rgx = new Regex(@"^[A-ZŠĐČĆŽ][a-zšđčćž]{2,}");
            return rgx.IsMatch(ime);
        }

        public static bool ValidirajRadioButton(List<RadioButton> dugmici)
        {
            foreach (RadioButton dugme in dugmici)
            {
                if (dugme.Checked) // jedno je cekirano
                    return true;
            }
            return false;
        }

        public static bool ValidirajJMBG(string jmbg)
        {
            Regex rgx = new Regex(@"\d");
            return rgx.IsMatch(jmbg) && jmbg.Length == 13;
        }

        public static bool ValidirajAdresu(string adresa)
        {
            Regex rgx = new Regex(@"\w{1,}");
            return rgx.IsMatch(adresa);
        }

        public static bool ValidirajKorisnickoIme(string korisnickoIme, List<string> imena)
        {
            return imena.Find(x => x.Equals(korisnickoIme)) == null && korisnickoIme.Length > 0;
        }

        public static bool ValidirajLozinku(string lozinka)
        {
            const int MIN_DUZINA = 6;
            const int MAX_DUZINA = 20;

            bool imaOdgovarajucuDuzinu = (lozinka.Length >= MIN_DUZINA && lozinka.Length <= MAX_DUZINA);
            bool imaMaloSlovo = false;
            bool imaVelikoSlovo = false;
            bool imaBroj = false;

            if (imaOdgovarajucuDuzinu)
            {
                foreach (char c in lozinka)
                {
                    if (char.IsLower(c)) imaMaloSlovo = true;
                    if (char.IsUpper(c)) imaVelikoSlovo = true;
                    if (char.IsDigit(c)) imaBroj = true;
                }
            }

            bool validnaLozinka = imaOdgovarajucuDuzinu
                               && imaMaloSlovo
                               && imaVelikoSlovo
                               && imaBroj;

            return validnaLozinka;
        }

        public static bool ValidirajPotvrdu(string lozinka, string potvrda)
        {
            return potvrda == lozinka;
        }
    }
}
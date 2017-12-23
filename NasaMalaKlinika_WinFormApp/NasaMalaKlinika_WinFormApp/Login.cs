using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NasaMalaKlinika;
using KlinikaOrdinacija;
using System.Security.Cryptography;

namespace NasaMalaKlinika_WinFormApp
{
    public partial class Login : Form
    {
        Ordinacija ordinacija;

        public Login()
        {
            InitializeComponent();
            ordinacija = null;
        }

        public string IzracunajMD5Hash(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] ulaz = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(ulaz);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text.Length == 0 && textBoxPassword.Text.Length == 0)
            {
                DoktorForma doktor = new DoktorForma();
                doktor.Show();
            }
            Uposlenik u = Klinika.uposlenici.Find(x => x.username == textBoxUsername.Text && x.password == IzracunajMD5Hash(textBoxPassword.Text));
            if(u != null)
            {
                if (u is Doktor)
                {
                    
                    string s = "Uspjesno prijavljen " + u.ime + " " + u.prezime;
                    MessageBox.Show(s);
                    DoktorForma dok = new DoktorForma(ref u);
                    dok.Show();
                }
            }
            else
            {
                MessageBox.Show("Ne postoji korisnik!");
            }
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            Registracija reg = new Registracija();
            reg.Show();
        }

        private void buttonVidljivo_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = (textBoxPassword.PasswordChar == '*' ? (char)0 : '*');
        }
    }
}

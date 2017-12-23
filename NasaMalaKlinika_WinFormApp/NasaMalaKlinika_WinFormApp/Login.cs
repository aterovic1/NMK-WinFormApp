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

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Graphics logo = this.CreateGraphics();
            //
            // crveni plus
            //
            Brush mojBrush = new SolidBrush(Color.Red);
            Pen olovka = new Pen(mojBrush, 5);
            Rectangle vodoravni = new Rectangle(50, 150, 200, 60);
            Rectangle uspravni = new Rectangle(120, 80, 60, 200);
            logo.DrawRectangle(new Pen(Color.Red, 3), vodoravni);
            logo.FillRectangle(mojBrush, vodoravni);
            logo.DrawRectangle(new Pen(Color.Red, 3), uspravni);
            logo.FillRectangle(mojBrush, uspravni);
            //
            // crvni krug oko plusa
            //
            Rectangle elipsaPravougaonik = new Rectangle(30, 60, 240, 240);
            logo.DrawEllipse(olovka, elipsaPravougaonik);
            //
            // vakcina
            //
            Brush crniBrush = new SolidBrush(Color.Black);
            Pen crnaOlovka4 = new Pen(crniBrush, 4);
            Point[] tacke = new Point[4];
            tacke[0] = new Point(230, 150);
            tacke[1] = new Point(120, 220);
            tacke[2] = new Point(100, 200);
            tacke[3] = new Point(210, 130);
            logo.DrawPolygon(crnaOlovka4, tacke);
            Brush bijeliBrush = new SolidBrush(Color.White);
            logo.FillPolygon(bijeliBrush, tacke);
            Pen linijaVakcina = new Pen(crniBrush);
            logo.DrawLine(crnaOlovka4, new Point(110, 211), new Point(70, 237));
            logo.DrawLine(crnaOlovka4, new Point(220, 140), new Point(235, 130));
            Pen crnaOlovka6 = new Pen(crniBrush, 6);
            logo.DrawLine(crnaOlovka6, new Point(232, 122), new Point(244, 138));
            logo.DrawLine(crnaOlovka4, new Point(140, 171), new Point(150, 181));
            logo.DrawLine(crnaOlovka4, new Point(150, 165), new Point(160, 175));
            logo.DrawLine(crnaOlovka4, new Point(160, 159), new Point(170, 169));
            logo.DrawLine(crnaOlovka4, new Point(170, 153), new Point(180, 163));
            //
            // vizuelna čarlama
            //
            Brush mojBrush1 = new SolidBrush(Form.DefaultBackColor);
            Rectangle a = new Rectangle(114, 10, 72, 60);
            logo.DrawRectangle(new Pen(Form.DefaultBackColor, 3), a);
            logo.FillRectangle(mojBrush1, a);
            //
            // NMK natpis
            //
            Font f1 = new Font("Verdana", 20, FontStyle.Bold);
            logo.DrawString("NMK", f1, new SolidBrush(ForeColor), 111, 45);
        }
    }
}

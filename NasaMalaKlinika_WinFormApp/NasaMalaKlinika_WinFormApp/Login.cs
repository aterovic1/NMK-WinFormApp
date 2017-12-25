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
            Uposlenik uposlenik = Klinika.uposlenici.Find(x => x.username == textBoxUsername.Text && x.password == IzracunajMD5Hash(textBoxPassword.Text));
            if(uposlenik != null)
            {
                if (uposlenik is Doktor)
                {
                    //string s = "Uspjesno prijavljen " + u.ime + " " + u.prezime;
                    //MessageBox.Show(s);
                    Ordinacija ordinacija = Klinika.ordinacije.Find(x => x.doktor == uposlenik);
                    if(ordinacija == null)
                    {
                        throw new Exception("Doktor nije niti u jednoj ordinaciji");
                    }
                    DoktorForma doktorForma = new DoktorForma(ref ordinacija);
                    doktorForma.Show();
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

        private void Login_Load(object sender, EventArgs e)
        {
            //
            // hardkodirani doktori radi testiranja
            //
            Doktor doktor1 = new Doktor("Meho", "Karabeg", Convert.ToDateTime("05.12.1975."), "0512975114528", "Behdzeta Mutevelica 56", Spol.musko, "Oženjen", 3500, "mkarabeg", "pass");
            Doktor doktor2 = new Doktor("Almir", "Kardovic", Convert.ToDateTime("15.08.1989."), "1508989147854", "Zmaja od Bosne 24", Spol.musko, "Neoženjen", 3000, "akardovic", "pass");
            Doktor doktor3 = new Doktor("Ena", "Hodzic", Convert.ToDateTime("07.12.1987."), "0712987452369", "Aleja Bosne srebrene 47", Spol.zensko, "Razvedena", 2700, "ehodzic", "pass");
            Doktor doktor4 = new Doktor("Alma", "Masic", Convert.ToDateTime("12.01.1965."), "1201965211478", "Safeta Zajke 158", Spol.zensko, "Udata", 1900, "amasic", "pass");
            Doktor doktor5 = new Doktor("Arnes", "Sehovic", Convert.ToDateTime("21.07.1970."), "2107970856654", "Alibega Firdusa 77", Spol.musko, "Razveden", 2350, "asehovic", "pass");
            Doktor doktor6 = new Doktor("Irma", "Dedovic", Convert.ToDateTime("29.06.1979."), "2906979147521", "Paromlinska 63", Spol.zensko, "Udata", 4100, "idedovic", "pass");
            Doktor doktor7 = new Doktor("Asim", "Omerovic", Convert.ToDateTime("01.11.1984."), "0111984663281", "Nedima Filipovica 12", Spol.musko, "neoženjen", 3560, "aomerovic", "pass");
            Doktor doktor8 = new Doktor("Lejla", "Durakovic", Convert.ToDateTime("10.03.1976."), "1003976541219", "Avdage Sahinagica 19", Spol.zensko, "Udovica", 2180, "ldurakovic", "pass");
            Doktor doktor9 = new Doktor("Osman", "Kustura", Convert.ToDateTime("14.02.1969."), "1402969365241", "Kasindolska 147", Spol.musko, "Oženjen", 3250, "okustura", "pass");
            //
            //dodavanje doktora u listu uposlenih
            //
            Klinika.RegistrirajUposlenog(doktor1);
            Klinika.RegistrirajUposlenog(doktor2);
            Klinika.RegistrirajUposlenog(doktor3);
            Klinika.RegistrirajUposlenog(doktor4);
            Klinika.RegistrirajUposlenog(doktor5);
            Klinika.RegistrirajUposlenog(doktor6);
            Klinika.RegistrirajUposlenog(doktor7);
            Klinika.RegistrirajUposlenog(doktor8);
            Klinika.RegistrirajUposlenog(doktor9);
            //
            //povezivanje doktora sa ordinacijama
            //
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[0], doktor1);
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[1], doktor2);
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[2], doktor3);
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[3], doktor4);
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[4], doktor5);
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[5], doktor6);
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[6], doktor7);
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[7], doktor8);
            Klinika.PoveziDoktoraSaOrdinacijom(Klinika.ordinacije[8], doktor9);
            //
            //kartoni
            //
            Karton karton17395_1 = new Karton("Polen", "Upala pluca", "Lose");
            Karton karton17395_2 = new Karton("Ne", "Bronhitis", "Dobro");
            Karton karton17395_3 = new Karton("Duhan", "Ospice", "Odlicno");
            Karton karton17395_4 = new Karton("Ne", "Infarkt", "Veoma lose");
            Karton karton17395_5 = new Karton("Ne", "Ne", "Lose");
            Karton karton17395_6 = new Karton("Kikiriki", "Ne", "Veoma dobro");
            Karton karton17395_7 = new Karton("Grinje", "Mozdani udar", "Dobro");
            Karton karton17395_8 = new Karton("Joha", "Ne", "Odlicno");
            Karton karton17395_9 = new Karton("Ne", "Srcani udar", "Dobro");
            Karton karton17395_10 = new Karton("Gluten", "Rak pluca", "Veoma lose");
            Karton karton17395_11 = new Karton("Duhan", "Ne", "Lose");
            Karton karton17395_12 = new Karton("Ne", "Povisen pritisak", "Veoma dobro");
            //
            //pregledi
            //
            List<Pregled> pregledi1 = new List<Pregled> { new Pregled(Klinika.ordinacije[0]), new Pregled(Klinika.ordinacije[2]), new Pregled(Klinika.ordinacije[5]) };
            List<Pregled> pregledi2 = new List<Pregled> { new Pregled(Klinika.ordinacije[1]), new Pregled(Klinika.ordinacije[0]) };
            List<Pregled> pregledi3 = new List<Pregled> { new Pregled(Klinika.ordinacije[8]), new Pregled(Klinika.ordinacije[4]), new Pregled(Klinika.ordinacije[7]) };
            List<Pregled> pregledi4 = new List<Pregled> { new Pregled(Klinika.ordinacije[7]), new Pregled(Klinika.ordinacije[3]) };
            List<Pregled> pregledi5 = new List<Pregled> { new Pregled(Klinika.ordinacije[6]) };
            List<Pregled> pregledi6 = new List<Pregled> { new Pregled(Klinika.ordinacije[5]), new Pregled(Klinika.ordinacije[6]), new Pregled(Klinika.ordinacije[0]) };
            List<Pregled> pregledi7 = new List<Pregled> { new Pregled(Klinika.ordinacije[1]) };
            List<Pregled> pregledi8 = new List<Pregled> { new Pregled(Klinika.ordinacije[4]), new Pregled(Klinika.ordinacije[8]) };
            List<Pregled> pregledi9 = new List<Pregled> { new Pregled(Klinika.ordinacije[3]), new Pregled(Klinika.ordinacije[0]), new Pregled(Klinika.ordinacije[2]) };
            List<Pregled> pregledi10 = new List<Pregled> { new Pregled(Klinika.ordinacije[1]), new Pregled(Klinika.ordinacije[5]) };
            List<Pregled> pregledi11 = new List<Pregled> { new Pregled(Klinika.ordinacije[6]), new Pregled(Klinika.ordinacije[7]), new Pregled(Klinika.ordinacije[4]), new Pregled(Klinika.ordinacije[3]) };
            List<Pregled> pregledi12 = new List<Pregled> { new Pregled(Klinika.ordinacije[1]), new Pregled(Klinika.ordinacije[3]), new Pregled(Klinika.ordinacije[5]), new Pregled(Klinika.ordinacije[0]), new Pregled(Klinika.ordinacije[8]) };
            //
            //hardkodirani pacijenti
            //
            Pacijent pacijent17395_1 = new Pacijent("Elvis", "Presley", Convert.ToDateTime("14.02.1969."), "1402969145258", "Kasindolska 147", Spol.musko, "Neoženjen", karton17395_1, pregledi1);
            Pacijent pacijent17395_2 = new Pacijent("Nino", "Prses", Convert.ToDateTime("18.12.1999."), "1402969145258", "Kasindolska 147", Spol.musko, "Razveden", karton17395_2, pregledi2);
            Pacijent pacijent17395_3 = new HitniPacijent("Selma", "Bajrami", Convert.ToDateTime("14.07.2001."), "1402969145258", "Kasindolska 147", Spol.zensko, "Udovac", karton17395_3, pregledi3, "reanimacija");
            Pacijent pacijent17395_4 = new Pacijent("Aida", "Halilovic", Convert.ToDateTime("06.06.2000."), "1402969145258", "Kasindolska 147", Spol.zensko, "Oženjen", karton17395_4, pregledi4);
            Pacijent pacijent17395_5 = new Pacijent("Amar", "Cizmic", Convert.ToDateTime("11.08.1959"), "1402969145258", "Kasindolska 147", Spol.musko, "Neoženjen", karton17395_5, pregledi5);
            Pacijent pacijent17395_6 = new HitniPacijent("Tarik", "Pribisic", Convert.ToDateTime("19.06.1988."), "1402969145258", "Kasindolska 147", Spol.musko, "Razveden", karton17395_6, pregledi6, "masaza srca");
            Pacijent pacijent17395_7 = new PacijentSmrtniIshod("Benjamin", "Franklin", Convert.ToDateTime("29.05.1996."), "1402969145258", "Kasindolska 147", Spol.musko, "Oženjen", "masaza srca", Convert.ToDateTime("17.11.2017"), "srcani udar");
            Pacijent pacijent17395_8 = new Pacijent("Nikola", "Tesla", Convert.ToDateTime("17.12.2005."), "1402969145258", "Kasindolska 147", Spol.musko, "Oženjen", karton17395_8, pregledi8);
            Pacijent pacijent17395_9 = new HitniPacijent("Marija", "Maric", Convert.ToDateTime("09.10.1979."), "1402969145258", "Kasindolska 147", Spol.zensko, "Udovac", karton17395_9, pregledi9, "vjestacko disanje");
            Pacijent pacijent17395_10 = new HitniPacijent("Hana", "Hanic", Convert.ToDateTime("06.09.1984."), "1402969145258", "Kasindolska 147", Spol.zensko, "Razveden", karton17395_10, pregledi10, "gips");
            Pacijent pacijent17395_11 = new Pacijent("Esma", "Muhovic", Convert.ToDateTime("03.02.1991."), "1402969145258", "Kasindolska 147", Spol.zensko, "Oženjen", karton17395_11, pregledi11);
            Pacijent pacijent17395_12 = new Pacijent("Fazila", "Gagula", Convert.ToDateTime("01.01.2000."), "1402969145258", "Kasindolska 147", Spol.zensko, "Neoženjen", karton17395_12, pregledi12);
            //
            //dodajemo pacijente u kliniku
            //
            Klinika.RegistrirajPacijenta(pacijent17395_1);
            Klinika.RegistrirajPacijenta(pacijent17395_2);
            Klinika.RegistrirajPacijenta(pacijent17395_3);
            Klinika.RegistrirajPacijenta(pacijent17395_4);
            Klinika.RegistrirajPacijenta(pacijent17395_5);
            Klinika.RegistrirajPacijenta(pacijent17395_6);
            Klinika.RegistrirajPacijenta(pacijent17395_7);
            Klinika.RegistrirajPacijenta(pacijent17395_8);
            Klinika.RegistrirajPacijenta(pacijent17395_9);
            Klinika.RegistrirajPacijenta(pacijent17395_10);
            Klinika.RegistrirajPacijenta(pacijent17395_11);
            Klinika.RegistrirajPacijenta(pacijent17395_12);
        }
    }
}

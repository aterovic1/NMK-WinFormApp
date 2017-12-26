using NasaMalaKlinika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaMalaKlinika_WinFormApp
{
    public partial class PacijentForma : Form
    {
        Pacijent pacijent;

        public PacijentForma()
        {
            InitializeComponent();
        }

        public PacijentForma(ref Pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
        }

        private void PacijentForma_Load(object sender, EventArgs e)
        {
            if (pacijent.slika != null)
            {
                pictureBoxSlika.Image = pacijent.slika;
            }
            else
            {
                pictureBoxSlika.Image = Properties.Resources.user;
            }
            richTextBoxKarton.Text = pacijent.karton.DajAnamnezu();
            if (pacijent.DajDugPacijenta() == 0)
            {
                labelDug.Text = "";
            }
            else
            {
                labelDug.Text = pacijent.DajDugPacijenta().ToString() + " KM";
            }
            string imePrezime = pacijent.ime + " " + pacijent.prezime;
            labelImePrezime.Text = imePrezime;
            labelImePrezime.ForeColor = Color.Blue;
            string zakazani = pacijent.PrikaziZakazanePreglede();
            string obavljeni = pacijent.PrikaziObavljenePregledeSaCijenom();
            if (zakazani.Count() == 0)
            {
                richTextBoxZakazani.Text = "Nemate zakazanih pregleda";
            }
            else
            {
                richTextBoxZakazani.Text = pacijent.PrikaziZakazanePreglede();
            }
            if(obavljeni.Count() == 0)
            {
                richTextBoxObavljeni.Text = "Niste obavili niti jedan pregled";
                labelDug.Text = "";
                labelPoruka.Text = "";
            }
            else
            {
                richTextBoxObavljeni.Text = pacijent.PrikaziObavljenePregledeSaCijenom();
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBoxSlika.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // pictureBoxSlika.BackgroundImageLayout = ImageLayout.Center;
        }

        private void ulijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image slika = pictureBoxSlika.Image;
            slika.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBoxSlika.Image = slika;
        }

        private void udesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image slika = pictureBoxSlika.Image;
            slika.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxSlika.Image = slika;
        }
    }
}

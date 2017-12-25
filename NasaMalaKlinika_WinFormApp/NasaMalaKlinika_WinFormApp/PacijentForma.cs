using NasaMalaKlinika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            richTextBoxKarton.Text = pacijent.karton.DajAnamnezu();
            labelDug.Text = pacijent.DajDugPacijenta().ToString() + " KM";
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

    }
}

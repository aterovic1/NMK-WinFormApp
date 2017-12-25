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
using KlinikaOrdinacija;

namespace NasaMalaKlinika_WinFormApp
{
    public partial class ObaviPregled : Form
    {
        Pacijent pacijent;
        Pregled pregled;
        ListView zakazani;
        Label poruka;

        public ObaviPregled()
        {
            InitializeComponent();
        }

        public ObaviPregled(ref Pacijent pacijent, ref Pregled pregled, ref ListView zakazani, ref Label poruka)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            this.pregled = pregled;
            this.zakazani = zakazani;
            this.poruka = poruka;
        }

        private void buttonPotvrda_Click(object sender, EventArgs e)
        {
            pacijent.ObaviPregled(dateTimePickerPregled.Value, richTextBoxRezultat.Text, textBoxTerapija.Text, pregled, pregled.ordinacija);
            if (pregled.ordinacija.listaCekanja.Count == 0)
            {
                poruka.Text = "Nema zakazanih pregleda";
            }
            if (MessageBox.Show("Pregled uspješno obavljen", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                zakazani.Items.RemoveAt(zakazani.SelectedIndices[0]);
                this.Close();
            }
        }
    }
}

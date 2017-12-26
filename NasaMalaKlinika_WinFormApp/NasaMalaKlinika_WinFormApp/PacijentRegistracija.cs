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
    public partial class PacijentRegistracija : Form
    {
        public PacijentRegistracija()
        {
            InitializeComponent();
        }
        private void radioButtonZensko_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxBrStanje.Items.Clear();
            comboBoxBrStanje.Items.AddRange(new object[] { "Udata", "Neudata", "Razvedena", "Udovica" });
            comboBoxBrStanje.SelectedIndex = comboBoxBrStanje.Items.IndexOf("Neudata");
        }

        private void radioButtonMusko_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxBrStanje.Items.Clear();
            comboBoxBrStanje.Items.AddRange(new object[] { "Oženjen", "Neoženjen", "Razveden", "Udovac" });
            comboBoxBrStanje.SelectedIndex = comboBoxBrStanje.Items.IndexOf("Neoženjen");
        }

        private void buttonPrikazPass_Click(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = (textBoxPass.PasswordChar == '*' ? (char)0 : '*');
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButtonMusko.Checked = false;
            radioButtonZensko.Checked = false;
            textBoxJMBG.Text = "";
            textBoxAdresa.Text = "";
            comboBoxBrStanje.SelectedIndex = -1;
            dateTimePicker1.Text = "";
            textBoxUser.ResetText();
            textBoxPass.ResetText();
            textBoxPotvrda.ResetText();
            textBoxUzrokSmrti.ResetText();
            textBoxPrvaPomoc.ResetText();
            radioButtonNormalni.Checked = false;
            radioButtonHitni.Checked = false;
            radioButtonSmrtni.Checked = false;
            checkedListBoxOrdinacije.ClearSelected();
            slikaDatum1.OcistiSlikuDatum();
        }

        private void buttonRegistrujSe_Click(object sender, EventArgs e)
        {
            Spol odabraniSpol = radioButtonMusko.Checked == true ? Spol.musko : Spol.zensko;
            Pacijent pacijent;
            if(radioButtonNormalni.Checked)
            {
                List<Pregled> zakazani = new List<Pregled>();
                foreach(KlinikaOrdinacija.Ordinacija ordinacija in Klinika.ordinacije)
                {
                    foreach(object o in checkedListBoxOrdinacije.CheckedItems)
                    {
                        if(o.ToString().Equals(ordinacija.tipPregleda))
                        {
                            zakazani.Add(new Pregled(ordinacija));
                        }
                    }
                }
                pacijent = new Pacijent(textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBoxJMBG.Text, textBoxAdresa.Text, odabraniSpol, comboBoxBrStanje.SelectedText, zakazani, textBoxUser.Text, textBoxPass.Text, slikaDatum1.DajSliku());
            }
            else if(radioButtonHitni.Checked)
            {
                List<Pregled> zakazani = new List<Pregled>();
                foreach (KlinikaOrdinacija.Ordinacija ordinacija in Klinika.ordinacije)
                {
                    foreach (object o in checkedListBoxOrdinacije.CheckedItems)
                    {
                        if (o.ToString().Equals(ordinacija.tipPregleda))
                        {
                            zakazani.Add(new Pregled(ordinacija));
                        }
                    }
                }
                pacijent = new HitniPacijent(textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBoxJMBG.Text, textBoxAdresa.Text, odabraniSpol, comboBoxBrStanje.SelectedText, zakazani, textBoxUser.Text, textBoxPass.Text, slikaDatum1.DajSliku(), textBoxPrvaPomoc.Text);
            }
            else
            {
                pacijent = new PacijentSmrtniIshod(textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBoxJMBG.Text, textBoxAdresa.Text, odabraniSpol, comboBoxBrStanje.SelectedText, slikaDatum1.DajSliku(), textBoxPrvaPomoc.Text, textBoxUzrokSmrti.Text);
            }
            Klinika.RegistrirajPacijenta(pacijent);
        }

        private void PacijentRegistracija_Load(object sender, EventArgs e)
        {
            radioButtonNormalni.Checked = true;
            labelPrvaPomoc.Enabled = false;
            labelUzrokSmrti.Enabled = false;
            textBoxUzrokSmrti.Enabled = false;
            textBoxPrvaPomoc.Enabled = false;
            checkedListBoxOrdinacije.Items.AddRange(new object[] { "Opšti pregled",
            "Kardiološki pregled",
            "Dermatološki pregled",
            "Ortopedski pregled",
            "Internistički pregled",
            "Otorinolaringološki pregled",
            "Oftamološki pregled",
            "Laboratorijski pregled",
            "Stomatološki pregled"});
            checkedListBoxOrdinacije.Enabled = false;
        }

        private void radioButtonNormalni_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxOrdinacije.Enabled = true;
            textBoxUzrokSmrti.ResetText();
            textBoxPrvaPomoc.ResetText();
        }

        private void radioButtonHitni_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxOrdinacije.Enabled = true;
            labelPrvaPomoc.Enabled = true;
            textBoxPrvaPomoc.Enabled = true;
            textBoxUzrokSmrti.ResetText();
        }

        private void radioButtonSmrtni_CheckedChanged(object sender, EventArgs e)
        {
            labelPrvaPomoc.Enabled = true;
            textBoxPrvaPomoc.Enabled = true;
            labelUzrokSmrti.Enabled = true;
            textBoxUzrokSmrti.Enabled = true;
            checkedListBoxOrdinacije.Enabled = false;
            textBoxPass.ResetText();
            textBoxUser.ResetText();
            textBoxUser.Enabled = false;
            textBoxPass.Enabled = false;
            labelUser.Enabled = false;
            labelPass.Enabled = false;
        }
    }
}

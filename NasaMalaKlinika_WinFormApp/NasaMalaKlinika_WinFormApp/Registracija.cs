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
    public partial class Registracija : Form
    {
        public Registracija()
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
            radioButtonDoktor.Checked = false;
            radioButtonObicni.Checked = false;
            comboBoxOrdinacije.SelectedIndex = -1;
        }

        private void buttonRegistrujSe_Click(object sender, EventArgs e)
        {
            Spol odabraniSpol = radioButtonMusko.Checked == true ? Spol.musko : Spol.zensko;
            if (radioButtonDoktor.Checked)
            {
                Klinika.RegistrirajUposlenog(new Doktor(textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBoxJMBG.Text, textBoxAdresa.Text, odabraniSpol, comboBoxBrStanje.SelectedText, 5000, textBoxUser.Text, textBoxPass.Text));
            }
            else
            {
                Klinika.RegistrirajUposlenog(new Uposlenik(textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBoxJMBG.Text, textBoxAdresa.Text, odabraniSpol, comboBoxBrStanje.SelectedText, 5000, textBoxUser.Text, textBoxPass.Text));
            }
        }

        private void radioButtonDoktor_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxOrdinacije.Enabled = true;
            labelOrdinacija.Enabled = true;
            comboBoxOrdinacije.SelectedIndex = comboBoxOrdinacije.Items.IndexOf("Opšti pregled");
        }

        private void radioButtonObicni_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxOrdinacije.Enabled = false;
            labelOrdinacija.Enabled = false;
            comboBoxOrdinacije.SelectedIndex = -1;
        }
    }
}

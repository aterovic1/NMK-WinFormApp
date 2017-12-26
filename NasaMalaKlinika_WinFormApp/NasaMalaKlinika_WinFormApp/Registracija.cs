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
            textBoxPass.PasswordChar = textBoxPotvrda.PasswordChar = (textBoxPass.PasswordChar == '*' ? (char)0 : '*');
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

        private bool ImaLiStaPrazno()
        {
            return textBox1.Text.Length == 0
                || textBox2.Text.Length == 0
                || textBoxJMBG.Text.Length == 0
                || textBoxAdresa.Text.Length == 0
                || textBoxUser.Text.Length == 0
                || textBoxPass.Text.Length == 0
                || textBoxPotvrda.Text.Length == 0;
        }

        private void buttonRegistrujSe_Click(object sender, EventArgs e)
        {
            if (!this.ImaLiStaPrazno() && Validacija.ValidirajRadioButton(new List<RadioButton>() { radioButtonMusko, radioButtonZensko })
                && Validacija.ValidirajRadioButton(new List<RadioButton>() { radioButtonDoktor, radioButtonObicni })) // sve je ok
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
                MessageBox.Show("Registracija uspješna", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Niti jedno polje ne smije biti prazno", "Upozorenje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
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

        private void Registracija_Load(object sender, EventArgs e)
        {
            textBoxPotvrda.Enabled = false;
        }

        private void textBoxPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxPass.TextLength > 0)
                textBoxPotvrda.Enabled = true;
        }

        #region
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.ValidirajImeIPrezime(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Select(0, textBox1.Text.Length);
                this.errorProviderIme.SetError(textBox1, "Ime nije validno");
                toolStripStatusLabelGreska.Text = "Ime nije validno";
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            this.errorProviderIme.SetError(textBox1, "");
            toolStripStatusLabelGreska.Text = "";
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.ValidirajImeIPrezime(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Select(0, textBox2.Text.Length);
                this.errorProviderPrezime.SetError(textBox2, "Prezime nije validno");
                toolStripStatusLabelGreska.Text = "Prezime nije validno";
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            this.errorProviderIme.SetError(textBox2, "");
            toolStripStatusLabelGreska.Text = "";
        }

        private void textBoxJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.ValidirajJMBG(textBoxJMBG.Text))
            {
                e.Cancel = true;
                textBoxJMBG.Select(0, textBoxJMBG.Text.Length);
                this.errorProviderJMBG.SetError(textBoxJMBG, "JMBG nije validan");
                toolStripStatusLabelGreska.Text = "JMBG nije validan";
            }
        }

        private void textBoxJMBG_Validated(object sender, EventArgs e)
        {
            this.errorProviderJMBG.SetError(textBoxJMBG, "");
            toolStripStatusLabelGreska.Text = "";
        }

        private void textBoxAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.ValidirajAdresu(textBoxAdresa.Text))
            {
                e.Cancel = true;
                textBoxAdresa.Select(0, textBoxAdresa.Text.Length);
                this.errorProviderAdresa.SetError(textBoxAdresa, "Adresa nije validna");
                toolStripStatusLabelGreska.Text = "Adresa nije validna";
            }
        }

        private void textBoxAdresa_Validated(object sender, EventArgs e)
        {
            this.errorProviderAdresa.SetError(textBoxAdresa, "");
            toolStripStatusLabelGreska.Text = "";
        }

        private void textBoxUser_Validating(object sender, CancelEventArgs e)
        {
            List<string> korisnickaImena = new List<string>();
            Klinika.uposlenici.ForEach(delegate (Uposlenik uposlenik)
            {
                korisnickaImena.Add(uposlenik.username);
            });
            if (!Validacija.ValidirajKorisnickoIme(textBoxUser.Text, korisnickaImena))
            {
                e.Cancel = true;
                textBoxUser.Select(0, textBoxUser.Text.Length);
                this.errorProviderAdresa.SetError(textBoxUser, "Korisnicko ime je zauzeto");
                toolStripStatusLabelGreska.Text = "Korisnicko ime je zauzeto";
            }
        }

        private void textBoxUser_Validated(object sender, EventArgs e)
        {
            this.errorProviderKorisnickoIme.SetError(textBoxUser, "");
            toolStripStatusLabelGreska.Text = "";
            errorProviderKorisnickoIme.Clear();
        }

        private void textBoxPass_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.ValidirajLozinku(textBoxPass.Text))
            {
                e.Cancel = true;
                textBoxPass.Select(0, textBoxPass.Text.Length);
                this.errorProviderLozinka.SetError(textBoxPass, "Lozinka nije validna");
                toolStripStatusLabelGreska.Text = "Lozinka nije validna";
            }
        }

        private void textBoxPass_Validated(object sender, EventArgs e)
        {
            this.errorProviderLozinka.SetError(textBoxPass, "");
            toolStripStatusLabelGreska.Text = "";
        }

        private void textBoxPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.ValidirajPotvrdu(textBoxPass.Text, textBoxPotvrda.Text))
            {
                e.Cancel = true;
                textBoxPotvrda.Select(0, textBoxPotvrda.Text.Length);
                this.errorProviderPotvrda.SetError(textBoxPotvrda, "Lozinke se ne poklapaju");
                toolStripStatusLabelGreska.Text = "Lozinke se ne poklapaju";
            }
        }

        private void textBoxPotvrda_Validated(object sender, EventArgs e)
        {
            this.errorProviderPotvrda.SetError(textBoxPotvrda, "");
            toolStripStatusLabelGreska.Text = "";
        }
        #endregion  // validacija
    }
}
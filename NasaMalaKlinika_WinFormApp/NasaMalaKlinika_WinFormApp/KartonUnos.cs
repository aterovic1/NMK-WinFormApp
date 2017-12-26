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
    public partial class KartonUnos : Form
    {
        Pacijent pacijent;

        public KartonUnos()
        {
            InitializeComponent();
        }

        public KartonUnos(ref Pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
        }

        private void radioButtonVrloLose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonLose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDobro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonVrloDobro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOdlicno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            string s = "";
            if (radioButtonVrloLose.Checked) s = radioButtonVrloLose.Text;
            else if (radioButtonLose.Checked) s = radioButtonLose.Text;
            else if (radioButtonDobro.Checked) s = radioButtonDobro.Text;
            else if (radioButtonVrloDobro.Checked) s = radioButtonVrloDobro.Text;
            else if (radioButtonOdlicno.Checked) s = radioButtonOdlicno.Text;
            Karton karton = new Karton(richTextBoxAlergije.Text, richTextBox1.Text, s);
            pacijent.karton = karton;
            if (MessageBox.Show("Karton uspješno registrovan", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void KartonUnos_Load(object sender, EventArgs e)
        {
            labelAlergija.Enabled = false;
            richTextBoxAlergije.Enabled = false;
            labelHistorija.Enabled = false;
            richTextBox1.Enabled = false;
        }

        private void radioButtonAlergijeDa_CheckedChanged(object sender, EventArgs e)
        {
            labelAlergija.Enabled = true;
            richTextBoxAlergije.Enabled = true;
        }

        private void radioButtonAlergijeNe_CheckedChanged(object sender, EventArgs e)
        {
            labelAlergija.Enabled = false;
            richTextBoxAlergije.Enabled = false;
        }

        private void radioButtonRanijeBolestiDa_CheckedChanged(object sender, EventArgs e)
        {
            labelHistorija.Enabled = true;
            richTextBox1.Enabled = true;
        }

        private void radioButtonRanijeBolestiNe_CheckedChanged(object sender, EventArgs e)
        {
            labelHistorija.Enabled = false;
            richTextBox1.Enabled = false;
        }
    }
}

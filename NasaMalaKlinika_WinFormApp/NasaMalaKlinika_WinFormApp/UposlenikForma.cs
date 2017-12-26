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

namespace NasaMalaKlinika_WinFormApp
{
    public partial class UposlenikForma : Form
    {
        public UposlenikForma()
        {
            InitializeComponent();
        }

        private void buttonRegistracijaPacijenta_Click(object sender, EventArgs e)
        {
            PacijentRegistracija pacijentRegistracija = new PacijentRegistracija();
            pacijentRegistracija.Show();
            AzurirajDrvo();
        }

        private void UposlenikForma_Load(object sender, EventArgs e)
        {
            AzurirajDrvo();
            buttonObrisi.Enabled = false;
        }

        private void AzurirajDrvo()
        {
            Klinika.ordinacije.ForEach(x => treeViewPacijenti.Nodes.Add(x.tipPregleda));
            for (int i = 0; i < Klinika.ordinacije.Count; i++)
            {
                treeViewPacijenti.Nodes[i].Nodes.Add("Zakazani pregledi");
                for (int j = 0; j < Klinika.ordinacije[i].listaCekanja.Count; j++)
                {
                    treeViewPacijenti.Nodes[i].Nodes[0].Nodes.Add(Klinika.ordinacije[i].listaCekanja[j].DajPunoIme());
                }
                
            }
        }

        private void comboBoxPretraga_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRezultatPretrage.Items.Clear();
            if (comboBoxPretraga.SelectedIndex == 0)
            {
                labelUnos.Text = "Unesite ID: ";
            }
            else if(comboBoxPretraga.SelectedIndex == 1)
            {
                labelUnos.Text = "Unesite JMBG: ";
            }
            else if(comboBoxPretraga.SelectedIndex == 2)
            {
                labelUnos.Text = "Unesite Ime: ";
            }
            else if(comboBoxPretraga.SelectedIndex == 3)
            {
                labelUnos.Text = "Unesite Prezime: ";
            }
            else if(comboBoxPretraga.SelectedIndex == 4)
            {
                labelUnos.Text = "Unesite puno ime: ";
            }
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            if (comboBoxPretraga.SelectedIndex == 0)
            {
                pacijenti.Add(Klinika.DajPacijentaSaId(Convert.ToInt64(textBox1.Text)));
            }
            else if (comboBoxPretraga.SelectedIndex == 1)
            {
                pacijenti.Add(Klinika.DajPacijentaSaJMBG(textBox1.Text));
            }
            else if (comboBoxPretraga.SelectedIndex == 2)
            {
                pacijenti = Klinika.DajPacijenteSaImenom(textBox1.Text);
            }
            else if (comboBoxPretraga.SelectedIndex == 3)
            {
                pacijenti = Klinika.DajPacijenteSaPrezimenom(textBox1.Text);
            }
            else if (comboBoxPretraga.SelectedIndex == 4)
            {
                pacijenti = Klinika.DajPacijenteSaImenomPrezimenom(textBox1.Text);
            }
            foreach (Pacijent pacijent in pacijenti)
            {
                listBoxRezultatPretrage.Items.Add(pacijent.DajPunoIme());
            }
            if(pacijenti.Count == 0)
            {
                labelNema.Text = "Pacijent nije pronađen.";
            }
        }

        private void listBoxRezultatPretrage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRezultatPretrage.SelectedIndex != -1)
            {
                buttonObrisi.Enabled = true;
            }
            else
            {
                buttonObrisi.Enabled = false;
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            Pacijent pacijent = Klinika.pacijenti.Find(x => x.DajPunoIme() == textBox1.Text);
            Klinika.IzbrisiPacijenta(pacijent);
            if(MessageBox.Show("Pacijent obrisan", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                listBoxRezultatPretrage.Items.Clear();
            }
        }
    }
}

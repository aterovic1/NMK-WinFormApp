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

namespace NasaMalaKlinika_WinFormApp
{
    public partial class DoktorForma : Form
    {
        Ordinacija ordinacija;

        public DoktorForma()
        {
            InitializeComponent();
        }

        public DoktorForma(ref Ordinacija ordinacija)
        {
            InitializeComponent();
            this.ordinacija = ordinacija;
            this.mojaOrdinacijaToolStripMenuItem.Text = ordinacija.tipPregleda;
            this.profilToolStripMenuItem.Text = ordinacija.doktor.DajPunoIme();
        }

        private void preglediToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DoktorForma_Load(object sender, EventArgs e)
        {
            /*
            ImageList listamala = new ImageList();
            ImageList listavelika = new ImageList();
            listamala.Images.Add(Bitmap.FromFile("C:\\Users\\Hp\\Desktop\\dig10k_penguin.bmp"));
            listamala.Images.Add(Bitmap.FromFile("C:\\Users\\Hp\\Desktop\\dig10k_penguin.bmp"));
            listavelika.Images.Add(Bitmap.FromFile("C:\\Users\\Hp\\Desktop\\dig10k_penguin.bmp"));
            listavelika.Images.Add(Bitmap.FromFile("C:\\Users\\Hp\\Desktop\\dig10k_penguin.bmp"));
            listViewZakazani.SmallImageList = listamala;
            listViewZakazani.LargeImageList = listavelika;
            */
            listViewZakazani.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewZakazani.Columns.Add("Ime", 100, HorizontalAlignment.Left);
            listViewZakazani.Columns.Add("Prezime", 100, HorizontalAlignment.Left);
            listViewZakazani.Columns.Add("Datum rođenja", 120, HorizontalAlignment.Left);
            foreach(Pacijent p in ordinacija.listaCekanja)
            {
                ListViewItem pacijent = new ListViewItem(p.idPacijenta.ToString());
                pacijent.SubItems.Add(p.ime);
                pacijent.SubItems.Add(p.prezime);
                pacijent.SubItems.Add(p.datumRođenja.ToShortDateString());
                listViewZakazani.Items.Add(pacijent);
            }
            if(ordinacija.listaCekanja.Count == 0)
            {
                labelNemaPregleda.Text = "Nema zakazanih pregleda";
            }

            listViewObavljeni.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewObavljeni.Columns.Add("Ime", 100, HorizontalAlignment.Left);
            listViewObavljeni.Columns.Add("Prezime", 100, HorizontalAlignment.Left);
            listViewObavljeni.Columns.Add("Datum rođenja", 120, HorizontalAlignment.Left);
            labelObavijest.Text = "Nije obavljen niti jedan pregled";
        }

        private void listViewZakazani_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewZakazani.SelectedItems.Count != 0)
            {
                Pacijent pacijent = ordinacija.listaCekanja.Find(x => listViewZakazani.SelectedItems[0].SubItems[0].Text == x.idPacijenta.ToString());
                richTextBoxPacijentDetaljno.Text = pacijent.karton.ToString();
                if (listViewZakazani.Items[0].Selected)
                {
                    buttonObaviPregled.Enabled = true;
                    buttonObaviPregled.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                }
            }
            else
            {
                richTextBoxPacijentDetaljno.Text = "";
                buttonObaviPregled.Enabled = false;
                buttonObaviPregled.BackColor = SystemColors.Control;
            }
        }

        private void buttonObaviPregled_Click(object sender, EventArgs e)
        {   
            Pacijent pacijent = ordinacija.listaCekanja.Find(x => listViewZakazani.SelectedItems[0].SubItems[0].Text == x.idPacijenta.ToString());
            Pregled pregled = pacijent.zakazaniPregledi.Find(x => x.ordinacija == ordinacija);
            ObaviPregled obavljanje = new ObaviPregled(ref pacijent, ref pregled, ref listViewZakazani, ref labelNemaPregleda);
            obavljanje.Show();
            if(listViewZakazani.Items.Count == 0)
            {
                buttonObaviPregled.Enabled = false;
                buttonObaviPregled.BackColor = SystemColors.Control;
            }
            ListViewItem pacijentObavljen = new ListViewItem(pacijent.idPacijenta.ToString());
            pacijentObavljen.SubItems.Add(pacijent.ime);
            pacijentObavljen.SubItems.Add(pacijent.prezime);
            pacijentObavljen.SubItems.Add(pacijent.datumRođenja.ToShortDateString());
            listViewObavljeni.Items.Add(pacijentObavljen);
            labelObavijest.Text = "";
        }

        private void tabPageZakazani_Leave(object sender, EventArgs e)
        {
            buttonObaviPregled.Enabled = false;
            buttonObaviPregled.BackColor = SystemColors.Control;
            richTextBoxPacijentDetaljno.Text = "";
        }

        private void tabPageObavljeni_Leave(object sender, EventArgs e)
        {
            richTextBoxDetaljno.Text = "";
        }

        private void listViewObavljeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewObavljeni.SelectedItems.Count != 0)
            {
                String s = "Pregledi u ovoj ordinaciji:\n\n";
                Pacijent pacijent = Klinika.pacijenti.Find(x => listViewObavljeni.SelectedItems[0].SubItems[0].Text == x.idPacijenta.ToString());
                s += pacijent.DajPregledeUOrdinaciji(ordinacija);
                richTextBoxDetaljno.Text = s;
            }
            else
            {
                richTextBoxDetaljno.Text = "";
            }
        }
    }
}

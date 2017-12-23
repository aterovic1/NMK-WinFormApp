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
    public partial class DoktorForma : Form
    {
        Uposlenik uposlenik;
        public DoktorForma()
        {
            InitializeComponent();
        }

        public DoktorForma(ref Uposlenik u)
        {
            InitializeComponent();
            uposlenik = u;
        }

        private void preglediToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}

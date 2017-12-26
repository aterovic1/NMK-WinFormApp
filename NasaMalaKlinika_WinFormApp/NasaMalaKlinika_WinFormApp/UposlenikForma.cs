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
        }
    }
}

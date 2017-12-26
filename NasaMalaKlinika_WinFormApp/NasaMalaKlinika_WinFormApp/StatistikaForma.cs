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
    public partial class StatistikaForma : Form
    {
        public StatistikaForma()
        {
            InitializeComponent();
        }

        private void StatistikaForma_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle rect = new Rectangle(30, 50, 200, 200);

            List<int> l = new List<int>(Klinika._IntProcenatPacijenataPoGodinama());

            int[] postotci = new int[4];

            postotci[0] = Convert.ToInt32((l[0] * 360) / Klinika.pacijenti.Count);
            postotci[1] = Convert.ToInt32((l[1] * 360) / Klinika.pacijenti.Count);
            postotci[2] = Convert.ToInt32((l[2] * 360) / Klinika.pacijenti.Count);
            postotci[3] = 360 - (postotci[0] + postotci[1] + postotci[2]);

            SolidBrush b1 = new SolidBrush(Color.Blue); 
            SolidBrush b2 = new SolidBrush(Color.OrangeRed);
            SolidBrush b3 = new SolidBrush(Color.DarkSeaGreen);
            SolidBrush b4 = new SolidBrush(Color.Goldenrod);

            graphics.FillPie(b1, rect, -90, postotci[0]);
            graphics.FillPie(b2, rect, -90 + postotci[0], postotci[1]);
            graphics.FillPie(b3, rect, -90 + postotci[0] + postotci[1], postotci[2]);
            graphics.FillPie(b4, rect, -90 + postotci[0] + postotci[1] + postotci[2], postotci[3]);

            SolidBrush crna = new SolidBrush(Color.Black);

            /*graphics.DrawString(l[0].ToString(), new Font("Verdana", 14), crna, new Point(50, 20));
            graphics.DrawString(l[1].ToString(), new Font("Verdana", 14), crna, new Point(60, 20));
            graphics.DrawString(l[2].ToString(), new Font("Verdana", 14), crna, new Point(70, 20));
            graphics.DrawString(l[3].ToString(), new Font("Verdana", 14), crna, new Point(80, 20));*/

            label1.Text += " (" + l[0].ToString() + ")";
            label2.Text += " (" + l[1].ToString() + ")";
            label3.Text += " (" + l[2].ToString() + ")";
            label4.Text += " (" + l[3].ToString() + ")";
            labelUkupno.Text += Klinika.pacijenti.Count;
        }

        private void StatistikaForma_Load(object sender, EventArgs e)
        {
            label9.Text = Klinika.NajposjecenijeOrdinacije();
        }
    }
}

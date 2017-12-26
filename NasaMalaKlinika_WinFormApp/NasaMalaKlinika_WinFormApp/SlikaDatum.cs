using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaMalaKlinika_WinFormApp
{
    public partial class SlikaDatum : UserControl
    {
        public SlikaDatum()
        {
            InitializeComponent();
        }

        private void buttonUcitajSliku_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Izaberite sliku"; dlg.Filter = "jpg files (*.jpg)|*.jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxSlika.Image = new Bitmap(dlg.FileName);
                }
            }
            pictureBoxSlika.BackgroundImageLayout = ImageLayout.Center;
        }

        private void dateTimePickerDatumSlike_ValueChanged(object sender, EventArgs e)
        {

        }
        public void OcistiSlikuDatum()
        {
            dateTimePickerDatumSlike.ResetText();
            pictureBoxSlika.Image = null;
        }
        public Image DajSliku()
        {
            return pictureBoxSlika.Image;
        }

        private void dateTimePickerDatumSlike_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePickerDatumSlike.Value < DateTime.Now.AddMonths(-6))
            {
                e.Cancel = true;
                errorProviderDatumSlike.SetError(dateTimePickerDatumSlike, "Slika ne smije biti starija od 6 mjeseci");
            }
        }

        private void dateTimePickerDatumSlike_Validated(object sender, EventArgs e)
        {
            errorProviderDatumSlike.SetError(dateTimePickerDatumSlike, "");
        }
    }
}

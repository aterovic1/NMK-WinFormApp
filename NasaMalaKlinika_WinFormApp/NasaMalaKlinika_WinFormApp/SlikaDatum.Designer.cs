namespace NasaMalaKlinika_WinFormApp
{
    partial class SlikaDatum
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            this.buttonUcitajSliku = new System.Windows.Forms.Button();
            this.dateTimePickerDatumSlike = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.Location = new System.Drawing.Point(40, 19);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(160, 137);
            this.pictureBoxSlika.TabIndex = 0;
            this.pictureBoxSlika.TabStop = false;
            // 
            // buttonUcitajSliku
            // 
            this.buttonUcitajSliku.Location = new System.Drawing.Point(40, 174);
            this.buttonUcitajSliku.Name = "buttonUcitajSliku";
            this.buttonUcitajSliku.Size = new System.Drawing.Size(160, 30);
            this.buttonUcitajSliku.TabIndex = 1;
            this.buttonUcitajSliku.Text = "Učitaj sliku";
            this.buttonUcitajSliku.UseVisualStyleBackColor = true;
            this.buttonUcitajSliku.Click += new System.EventHandler(this.buttonUcitajSliku_Click);
            // 
            // dateTimePickerDatumSlike
            // 
            this.dateTimePickerDatumSlike.Location = new System.Drawing.Point(23, 220);
            this.dateTimePickerDatumSlike.Name = "dateTimePickerDatumSlike";
            this.dateTimePickerDatumSlike.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatumSlike.TabIndex = 2;
            this.dateTimePickerDatumSlike.ValueChanged += new System.EventHandler(this.dateTimePickerDatumSlike_ValueChanged);
            // 
            // SlikaDatum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerDatumSlike);
            this.Controls.Add(this.buttonUcitajSliku);
            this.Controls.Add(this.pictureBoxSlika);
            this.Name = "SlikaDatum";
            this.Size = new System.Drawing.Size(242, 262);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSlika;
        private System.Windows.Forms.Button buttonUcitajSliku;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumSlike;
    }
}

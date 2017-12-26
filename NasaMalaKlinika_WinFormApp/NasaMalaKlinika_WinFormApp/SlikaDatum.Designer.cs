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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            this.buttonUcitajSliku = new System.Windows.Forms.Button();
            this.dateTimePickerDatumSlike = new System.Windows.Forms.DateTimePicker();
            this.labelDatumSlike = new System.Windows.Forms.Label();
            this.errorProviderDatumSlike = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDatumSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlika.Location = new System.Drawing.Point(22, 9);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(158, 128);
            this.pictureBoxSlika.TabIndex = 0;
            this.pictureBoxSlika.TabStop = false;
            // 
            // buttonUcitajSliku
            // 
            this.buttonUcitajSliku.Location = new System.Drawing.Point(22, 143);
            this.buttonUcitajSliku.Name = "buttonUcitajSliku";
            this.buttonUcitajSliku.Size = new System.Drawing.Size(158, 30);
            this.buttonUcitajSliku.TabIndex = 1;
            this.buttonUcitajSliku.Text = "Učitaj sliku";
            this.buttonUcitajSliku.UseVisualStyleBackColor = true;
            this.buttonUcitajSliku.Click += new System.EventHandler(this.buttonUcitajSliku_Click);
            // 
            // dateTimePickerDatumSlike
            // 
            this.dateTimePickerDatumSlike.Location = new System.Drawing.Point(22, 212);
            this.dateTimePickerDatumSlike.Name = "dateTimePickerDatumSlike";
            this.dateTimePickerDatumSlike.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerDatumSlike.TabIndex = 2;
            this.dateTimePickerDatumSlike.ValueChanged += new System.EventHandler(this.dateTimePickerDatumSlike_ValueChanged);
            this.dateTimePickerDatumSlike.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDatumSlike_Validating);
            this.dateTimePickerDatumSlike.Validated += new System.EventHandler(this.dateTimePickerDatumSlike_Validated);
            // 
            // labelDatumSlike
            // 
            this.labelDatumSlike.AutoSize = true;
            this.labelDatumSlike.Location = new System.Drawing.Point(65, 196);
            this.labelDatumSlike.Name = "labelDatumSlike";
            this.labelDatumSlike.Size = new System.Drawing.Size(76, 13);
            this.labelDatumSlike.TabIndex = 3;
            this.labelDatumSlike.Text = "Datum slikanja";
            // 
            // errorProviderDatumSlike
            // 
            this.errorProviderDatumSlike.ContainerControl = this;
            // 
            // SlikaDatum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDatumSlike);
            this.Controls.Add(this.dateTimePickerDatumSlike);
            this.Controls.Add(this.buttonUcitajSliku);
            this.Controls.Add(this.pictureBoxSlika);
            this.Name = "SlikaDatum";
            this.Size = new System.Drawing.Size(205, 247);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDatumSlike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSlika;
        private System.Windows.Forms.Button buttonUcitajSliku;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumSlike;
        private System.Windows.Forms.Label labelDatumSlike;
        private System.Windows.Forms.ErrorProvider errorProviderDatumSlike;
    }
}

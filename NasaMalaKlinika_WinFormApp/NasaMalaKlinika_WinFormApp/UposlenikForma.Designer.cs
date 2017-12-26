namespace NasaMalaKlinika_WinFormApp
{
    partial class UposlenikForma
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UposlenikForma));
            this.buttonRegistracijaPacijenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistracijaPacijenta
            // 
            this.buttonRegistracijaPacijenta.Location = new System.Drawing.Point(39, 33);
            this.buttonRegistracijaPacijenta.Name = "buttonRegistracijaPacijenta";
            this.buttonRegistracijaPacijenta.Size = new System.Drawing.Size(151, 23);
            this.buttonRegistracijaPacijenta.TabIndex = 0;
            this.buttonRegistracijaPacijenta.Text = "Registruj pacijenta";
            this.buttonRegistracijaPacijenta.UseVisualStyleBackColor = true;
            this.buttonRegistracijaPacijenta.Click += new System.EventHandler(this.buttonRegistracijaPacijenta_Click);
            // 
            // UposlenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonRegistracijaPacijenta);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UposlenikForma";
            this.Text = "Naša Mala Klinika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistracijaPacijenta;
    }
}
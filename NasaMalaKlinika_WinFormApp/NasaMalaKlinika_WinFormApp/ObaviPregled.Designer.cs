namespace NasaMalaKlinika_WinFormApp
{
    partial class ObaviPregled
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
            this.labelDatum = new System.Windows.Forms.Label();
            this.dateTimePickerPregled = new System.Windows.Forms.DateTimePicker();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.richTextBoxRezultat = new System.Windows.Forms.RichTextBox();
            this.labelTerapija = new System.Windows.Forms.Label();
            this.textBoxTerapija = new System.Windows.Forms.TextBox();
            this.buttonPotvrda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(25, 28);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(85, 13);
            this.labelDatum.TabIndex = 0;
            this.labelDatum.Text = "Datum pregleda:";
            // 
            // dateTimePickerPregled
            // 
            this.dateTimePickerPregled.Location = new System.Drawing.Point(28, 55);
            this.dateTimePickerPregled.Name = "dateTimePickerPregled";
            this.dateTimePickerPregled.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerPregled.TabIndex = 1;
            // 
            // labelRezultat
            // 
            this.labelRezultat.AutoSize = true;
            this.labelRezultat.Location = new System.Drawing.Point(25, 96);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(93, 13);
            this.labelRezultat.TabIndex = 2;
            this.labelRezultat.Text = "Rezultat pregleda:";
            // 
            // richTextBoxRezultat
            // 
            this.richTextBoxRezultat.Location = new System.Drawing.Point(28, 123);
            this.richTextBoxRezultat.Name = "richTextBoxRezultat";
            this.richTextBoxRezultat.Size = new System.Drawing.Size(191, 68);
            this.richTextBoxRezultat.TabIndex = 3;
            this.richTextBoxRezultat.Text = "";
            // 
            // labelTerapija
            // 
            this.labelTerapija.AutoSize = true;
            this.labelTerapija.Location = new System.Drawing.Point(25, 209);
            this.labelTerapija.Name = "labelTerapija";
            this.labelTerapija.Size = new System.Drawing.Size(48, 13);
            this.labelTerapija.TabIndex = 4;
            this.labelTerapija.Text = "Terapija:";
            // 
            // textBoxTerapija
            // 
            this.textBoxTerapija.Location = new System.Drawing.Point(28, 236);
            this.textBoxTerapija.Name = "textBoxTerapija";
            this.textBoxTerapija.Size = new System.Drawing.Size(188, 20);
            this.textBoxTerapija.TabIndex = 5;
            // 
            // buttonPotvrda
            // 
            this.buttonPotvrda.Location = new System.Drawing.Point(77, 271);
            this.buttonPotvrda.Name = "buttonPotvrda";
            this.buttonPotvrda.Size = new System.Drawing.Size(75, 32);
            this.buttonPotvrda.TabIndex = 6;
            this.buttonPotvrda.Text = "Potvrdi";
            this.buttonPotvrda.UseVisualStyleBackColor = true;
            this.buttonPotvrda.Click += new System.EventHandler(this.buttonPotvrda_Click);
            // 
            // ObaviPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 324);
            this.Controls.Add(this.buttonPotvrda);
            this.Controls.Add(this.textBoxTerapija);
            this.Controls.Add(this.labelTerapija);
            this.Controls.Add(this.richTextBoxRezultat);
            this.Controls.Add(this.labelRezultat);
            this.Controls.Add(this.dateTimePickerPregled);
            this.Controls.Add(this.labelDatum);
            this.Name = "ObaviPregled";
            this.Text = "ObaviPregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerPregled;
        private System.Windows.Forms.Label labelRezultat;
        private System.Windows.Forms.RichTextBox richTextBoxRezultat;
        private System.Windows.Forms.Label labelTerapija;
        private System.Windows.Forms.TextBox textBoxTerapija;
        private System.Windows.Forms.Button buttonPotvrda;
    }
}
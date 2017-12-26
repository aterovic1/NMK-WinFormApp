namespace NasaMalaKlinika_WinFormApp
{
    partial class KartonUnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KartonUnos));
            this.labelAlergija = new System.Windows.Forms.Label();
            this.labelHistorija = new System.Windows.Forms.Label();
            this.radioButtonVrloLose = new System.Windows.Forms.RadioButton();
            this.radioButtonLose = new System.Windows.Forms.RadioButton();
            this.radioButtonDobro = new System.Windows.Forms.RadioButton();
            this.radioButtonVrloDobro = new System.Windows.Forms.RadioButton();
            this.radioButtonOdlicno = new System.Windows.Forms.RadioButton();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.groupBoxOpceStanje = new System.Windows.Forms.GroupBox();
            this.groupBoxAlergije = new System.Windows.Forms.GroupBox();
            this.groupBoxRanijeBolesti = new System.Windows.Forms.GroupBox();
            this.labelPitanjeAlergije = new System.Windows.Forms.Label();
            this.radioButtonAlergijeDa = new System.Windows.Forms.RadioButton();
            this.radioButtonAlergijeNe = new System.Windows.Forms.RadioButton();
            this.labelRanijeBolestiPitanje = new System.Windows.Forms.Label();
            this.radioButtonRanijeBolestiDa = new System.Windows.Forms.RadioButton();
            this.radioButtonRanijeBolestiNe = new System.Windows.Forms.RadioButton();
            this.richTextBoxAlergije = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxOpceStanje.SuspendLayout();
            this.groupBoxAlergije.SuspendLayout();
            this.groupBoxRanijeBolesti.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAlergija
            // 
            this.labelAlergija.AutoSize = true;
            this.labelAlergija.Location = new System.Drawing.Point(6, 98);
            this.labelAlergija.Name = "labelAlergija";
            this.labelAlergija.Size = new System.Drawing.Size(159, 14);
            this.labelAlergija.TabIndex = 0;
            this.labelAlergija.Text = "Pacijent je alergičan na:";
            // 
            // labelHistorija
            // 
            this.labelHistorija.AutoSize = true;
            this.labelHistorija.Location = new System.Drawing.Point(11, 98);
            this.labelHistorija.Name = "labelHistorija";
            this.labelHistorija.Size = new System.Drawing.Size(97, 14);
            this.labelHistorija.TabIndex = 2;
            this.labelHistorija.Text = "Ranije bolesti:";
            // 
            // radioButtonVrloLose
            // 
            this.radioButtonVrloLose.AutoSize = true;
            this.radioButtonVrloLose.Location = new System.Drawing.Point(34, 33);
            this.radioButtonVrloLose.Name = "radioButtonVrloLose";
            this.radioButtonVrloLose.Size = new System.Drawing.Size(79, 18);
            this.radioButtonVrloLose.TabIndex = 5;
            this.radioButtonVrloLose.TabStop = true;
            this.radioButtonVrloLose.Text = "Vrlo loše";
            this.radioButtonVrloLose.UseVisualStyleBackColor = true;
            this.radioButtonVrloLose.CheckedChanged += new System.EventHandler(this.radioButtonVrloLose_CheckedChanged);
            // 
            // radioButtonLose
            // 
            this.radioButtonLose.AutoSize = true;
            this.radioButtonLose.Location = new System.Drawing.Point(119, 33);
            this.radioButtonLose.Name = "radioButtonLose";
            this.radioButtonLose.Size = new System.Drawing.Size(55, 18);
            this.radioButtonLose.TabIndex = 6;
            this.radioButtonLose.TabStop = true;
            this.radioButtonLose.Text = "Loše";
            this.radioButtonLose.UseVisualStyleBackColor = true;
            this.radioButtonLose.CheckedChanged += new System.EventHandler(this.radioButtonLose_CheckedChanged);
            // 
            // radioButtonDobro
            // 
            this.radioButtonDobro.AutoSize = true;
            this.radioButtonDobro.Location = new System.Drawing.Point(180, 33);
            this.radioButtonDobro.Name = "radioButtonDobro";
            this.radioButtonDobro.Size = new System.Drawing.Size(63, 18);
            this.radioButtonDobro.TabIndex = 7;
            this.radioButtonDobro.TabStop = true;
            this.radioButtonDobro.Text = "Dobro";
            this.radioButtonDobro.UseVisualStyleBackColor = true;
            this.radioButtonDobro.CheckedChanged += new System.EventHandler(this.radioButtonDobro_CheckedChanged);
            // 
            // radioButtonVrloDobro
            // 
            this.radioButtonVrloDobro.AutoSize = true;
            this.radioButtonVrloDobro.Location = new System.Drawing.Point(249, 33);
            this.radioButtonVrloDobro.Name = "radioButtonVrloDobro";
            this.radioButtonVrloDobro.Size = new System.Drawing.Size(90, 18);
            this.radioButtonVrloDobro.TabIndex = 8;
            this.radioButtonVrloDobro.TabStop = true;
            this.radioButtonVrloDobro.Text = "Vrlo dobro";
            this.radioButtonVrloDobro.UseVisualStyleBackColor = true;
            this.radioButtonVrloDobro.CheckedChanged += new System.EventHandler(this.radioButtonVrloDobro_CheckedChanged);
            // 
            // radioButtonOdlicno
            // 
            this.radioButtonOdlicno.AutoSize = true;
            this.radioButtonOdlicno.Location = new System.Drawing.Point(345, 33);
            this.radioButtonOdlicno.Name = "radioButtonOdlicno";
            this.radioButtonOdlicno.Size = new System.Drawing.Size(71, 18);
            this.radioButtonOdlicno.TabIndex = 9;
            this.radioButtonOdlicno.TabStop = true;
            this.radioButtonOdlicno.Text = "Odlično";
            this.radioButtonOdlicno.UseVisualStyleBackColor = true;
            this.radioButtonOdlicno.CheckedChanged += new System.EventHandler(this.radioButtonOdlicno_CheckedChanged);
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(527, 331);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(117, 32);
            this.buttonUnesi.TabIndex = 10;
            this.buttonUnesi.Text = "Kreiraj karton";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // groupBoxOpceStanje
            // 
            this.groupBoxOpceStanje.Controls.Add(this.radioButtonVrloLose);
            this.groupBoxOpceStanje.Controls.Add(this.radioButtonLose);
            this.groupBoxOpceStanje.Controls.Add(this.radioButtonOdlicno);
            this.groupBoxOpceStanje.Controls.Add(this.radioButtonDobro);
            this.groupBoxOpceStanje.Controls.Add(this.radioButtonVrloDobro);
            this.groupBoxOpceStanje.Location = new System.Drawing.Point(37, 305);
            this.groupBoxOpceStanje.Name = "groupBoxOpceStanje";
            this.groupBoxOpceStanje.Size = new System.Drawing.Size(445, 62);
            this.groupBoxOpceStanje.TabIndex = 11;
            this.groupBoxOpceStanje.TabStop = false;
            this.groupBoxOpceStanje.Text = "Opće zdravstveno stanje u porodici";
            // 
            // groupBoxAlergije
            // 
            this.groupBoxAlergije.Controls.Add(this.richTextBoxAlergije);
            this.groupBoxAlergije.Controls.Add(this.radioButtonAlergijeNe);
            this.groupBoxAlergije.Controls.Add(this.radioButtonAlergijeDa);
            this.groupBoxAlergije.Controls.Add(this.labelPitanjeAlergije);
            this.groupBoxAlergije.Controls.Add(this.labelAlergija);
            this.groupBoxAlergije.Location = new System.Drawing.Point(37, 38);
            this.groupBoxAlergije.Name = "groupBoxAlergije";
            this.groupBoxAlergije.Size = new System.Drawing.Size(286, 232);
            this.groupBoxAlergije.TabIndex = 12;
            this.groupBoxAlergije.TabStop = false;
            this.groupBoxAlergije.Text = "Podaci o alergijama";
            // 
            // groupBoxRanijeBolesti
            // 
            this.groupBoxRanijeBolesti.Controls.Add(this.richTextBox1);
            this.groupBoxRanijeBolesti.Controls.Add(this.radioButtonRanijeBolestiNe);
            this.groupBoxRanijeBolesti.Controls.Add(this.radioButtonRanijeBolestiDa);
            this.groupBoxRanijeBolesti.Controls.Add(this.labelRanijeBolestiPitanje);
            this.groupBoxRanijeBolesti.Controls.Add(this.labelHistorija);
            this.groupBoxRanijeBolesti.Location = new System.Drawing.Point(345, 38);
            this.groupBoxRanijeBolesti.Name = "groupBoxRanijeBolesti";
            this.groupBoxRanijeBolesti.Size = new System.Drawing.Size(305, 232);
            this.groupBoxRanijeBolesti.TabIndex = 13;
            this.groupBoxRanijeBolesti.TabStop = false;
            this.groupBoxRanijeBolesti.Text = "Podaci o ranijim bolestima";
            // 
            // labelPitanjeAlergije
            // 
            this.labelPitanjeAlergije.AutoSize = true;
            this.labelPitanjeAlergije.Location = new System.Drawing.Point(9, 31);
            this.labelPitanjeAlergije.Name = "labelPitanjeAlergije";
            this.labelPitanjeAlergije.Size = new System.Drawing.Size(207, 14);
            this.labelPitanjeAlergije.TabIndex = 1;
            this.labelPitanjeAlergije.Text = "Da li pacijent ima neke alergije?";
            // 
            // radioButtonAlergijeDa
            // 
            this.radioButtonAlergijeDa.AutoSize = true;
            this.radioButtonAlergijeDa.Location = new System.Drawing.Point(42, 61);
            this.radioButtonAlergijeDa.Name = "radioButtonAlergijeDa";
            this.radioButtonAlergijeDa.Size = new System.Drawing.Size(42, 18);
            this.radioButtonAlergijeDa.TabIndex = 2;
            this.radioButtonAlergijeDa.TabStop = true;
            this.radioButtonAlergijeDa.Text = "Da";
            this.radioButtonAlergijeDa.UseVisualStyleBackColor = true;
            this.radioButtonAlergijeDa.CheckedChanged += new System.EventHandler(this.radioButtonAlergijeDa_CheckedChanged);
            // 
            // radioButtonAlergijeNe
            // 
            this.radioButtonAlergijeNe.AutoSize = true;
            this.radioButtonAlergijeNe.Location = new System.Drawing.Point(90, 61);
            this.radioButtonAlergijeNe.Name = "radioButtonAlergijeNe";
            this.radioButtonAlergijeNe.Size = new System.Drawing.Size(42, 18);
            this.radioButtonAlergijeNe.TabIndex = 3;
            this.radioButtonAlergijeNe.TabStop = true;
            this.radioButtonAlergijeNe.Text = "Ne";
            this.radioButtonAlergijeNe.UseVisualStyleBackColor = true;
            this.radioButtonAlergijeNe.CheckedChanged += new System.EventHandler(this.radioButtonAlergijeNe_CheckedChanged);
            // 
            // labelRanijeBolestiPitanje
            // 
            this.labelRanijeBolestiPitanje.AutoSize = true;
            this.labelRanijeBolestiPitanje.Location = new System.Drawing.Point(11, 31);
            this.labelRanijeBolestiPitanje.Name = "labelRanijeBolestiPitanje";
            this.labelRanijeBolestiPitanje.Size = new System.Drawing.Size(275, 14);
            this.labelRanijeBolestiPitanje.TabIndex = 3;
            this.labelRanijeBolestiPitanje.Text = "Da li je pacijent ranije bolovao od nečega?";
            // 
            // radioButtonRanijeBolestiDa
            // 
            this.radioButtonRanijeBolestiDa.AutoSize = true;
            this.radioButtonRanijeBolestiDa.Location = new System.Drawing.Point(85, 61);
            this.radioButtonRanijeBolestiDa.Name = "radioButtonRanijeBolestiDa";
            this.radioButtonRanijeBolestiDa.Size = new System.Drawing.Size(42, 18);
            this.radioButtonRanijeBolestiDa.TabIndex = 4;
            this.radioButtonRanijeBolestiDa.TabStop = true;
            this.radioButtonRanijeBolestiDa.Text = "Da";
            this.radioButtonRanijeBolestiDa.UseVisualStyleBackColor = true;
            this.radioButtonRanijeBolestiDa.CheckedChanged += new System.EventHandler(this.radioButtonRanijeBolestiDa_CheckedChanged);
            // 
            // radioButtonRanijeBolestiNe
            // 
            this.radioButtonRanijeBolestiNe.AutoSize = true;
            this.radioButtonRanijeBolestiNe.Location = new System.Drawing.Point(133, 61);
            this.radioButtonRanijeBolestiNe.Name = "radioButtonRanijeBolestiNe";
            this.radioButtonRanijeBolestiNe.Size = new System.Drawing.Size(42, 18);
            this.radioButtonRanijeBolestiNe.TabIndex = 5;
            this.radioButtonRanijeBolestiNe.TabStop = true;
            this.radioButtonRanijeBolestiNe.Text = "Ne";
            this.radioButtonRanijeBolestiNe.UseVisualStyleBackColor = true;
            this.radioButtonRanijeBolestiNe.CheckedChanged += new System.EventHandler(this.radioButtonRanijeBolestiNe_CheckedChanged);
            // 
            // richTextBoxAlergije
            // 
            this.richTextBoxAlergije.Location = new System.Drawing.Point(12, 130);
            this.richTextBoxAlergije.Name = "richTextBoxAlergije";
            this.richTextBoxAlergije.Size = new System.Drawing.Size(268, 96);
            this.richTextBoxAlergije.TabIndex = 4;
            this.richTextBoxAlergije.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // KartonUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 386);
            this.Controls.Add(this.groupBoxRanijeBolesti);
            this.Controls.Add(this.groupBoxAlergije);
            this.Controls.Add(this.groupBoxOpceStanje);
            this.Controls.Add(this.buttonUnesi);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KartonUnos";
            this.Text = "Karton pacijenta";
            this.Load += new System.EventHandler(this.KartonUnos_Load);
            this.groupBoxOpceStanje.ResumeLayout(false);
            this.groupBoxOpceStanje.PerformLayout();
            this.groupBoxAlergije.ResumeLayout(false);
            this.groupBoxAlergije.PerformLayout();
            this.groupBoxRanijeBolesti.ResumeLayout(false);
            this.groupBoxRanijeBolesti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAlergija;
        private System.Windows.Forms.Label labelHistorija;
        private System.Windows.Forms.RadioButton radioButtonVrloLose;
        private System.Windows.Forms.RadioButton radioButtonLose;
        private System.Windows.Forms.RadioButton radioButtonDobro;
        private System.Windows.Forms.RadioButton radioButtonVrloDobro;
        private System.Windows.Forms.RadioButton radioButtonOdlicno;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.GroupBox groupBoxOpceStanje;
        private System.Windows.Forms.GroupBox groupBoxAlergije;
        private System.Windows.Forms.RichTextBox richTextBoxAlergije;
        private System.Windows.Forms.RadioButton radioButtonAlergijeNe;
        private System.Windows.Forms.RadioButton radioButtonAlergijeDa;
        private System.Windows.Forms.Label labelPitanjeAlergije;
        private System.Windows.Forms.GroupBox groupBoxRanijeBolesti;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButtonRanijeBolestiNe;
        private System.Windows.Forms.RadioButton radioButtonRanijeBolestiDa;
        private System.Windows.Forms.Label labelRanijeBolestiPitanje;
    }
}
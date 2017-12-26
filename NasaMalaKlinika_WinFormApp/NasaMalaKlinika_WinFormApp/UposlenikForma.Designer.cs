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
            this.treeViewPacijenti = new System.Windows.Forms.TreeView();
            this.groupBoxOrdinacije = new System.Windows.Forms.GroupBox();
            this.groupBoxPacijenti = new System.Windows.Forms.GroupBox();
            this.labelPretraga = new System.Windows.Forms.Label();
            this.comboBoxPretraga = new System.Windows.Forms.ComboBox();
            this.labelUnos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxRezultatPretrage = new System.Windows.Forms.ListBox();
            this.buttonPretraga = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.labelNema = new System.Windows.Forms.Label();
            this.groupBoxOrdinacije.SuspendLayout();
            this.groupBoxPacijenti.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegistracijaPacijenta
            // 
            this.buttonRegistracijaPacijenta.Location = new System.Drawing.Point(191, 285);
            this.buttonRegistracijaPacijenta.Name = "buttonRegistracijaPacijenta";
            this.buttonRegistracijaPacijenta.Size = new System.Drawing.Size(131, 44);
            this.buttonRegistracijaPacijenta.TabIndex = 0;
            this.buttonRegistracijaPacijenta.Text = "Registruj novog pacijenta";
            this.buttonRegistracijaPacijenta.UseVisualStyleBackColor = true;
            this.buttonRegistracijaPacijenta.Click += new System.EventHandler(this.buttonRegistracijaPacijenta_Click);
            // 
            // treeViewPacijenti
            // 
            this.treeViewPacijenti.Location = new System.Drawing.Point(6, 21);
            this.treeViewPacijenti.Name = "treeViewPacijenti";
            this.treeViewPacijenti.Size = new System.Drawing.Size(253, 318);
            this.treeViewPacijenti.TabIndex = 1;
            // 
            // groupBoxOrdinacije
            // 
            this.groupBoxOrdinacije.Controls.Add(this.treeViewPacijenti);
            this.groupBoxOrdinacije.Location = new System.Drawing.Point(24, 30);
            this.groupBoxOrdinacije.Name = "groupBoxOrdinacije";
            this.groupBoxOrdinacije.Size = new System.Drawing.Size(266, 345);
            this.groupBoxOrdinacije.TabIndex = 2;
            this.groupBoxOrdinacije.TabStop = false;
            this.groupBoxOrdinacije.Text = "Pregled ordinacija";
            // 
            // groupBoxPacijenti
            // 
            this.groupBoxPacijenti.Controls.Add(this.labelNema);
            this.groupBoxPacijenti.Controls.Add(this.buttonObrisi);
            this.groupBoxPacijenti.Controls.Add(this.buttonPretraga);
            this.groupBoxPacijenti.Controls.Add(this.listBoxRezultatPretrage);
            this.groupBoxPacijenti.Controls.Add(this.textBox1);
            this.groupBoxPacijenti.Controls.Add(this.labelUnos);
            this.groupBoxPacijenti.Controls.Add(this.comboBoxPretraga);
            this.groupBoxPacijenti.Controls.Add(this.labelPretraga);
            this.groupBoxPacijenti.Controls.Add(this.buttonRegistracijaPacijenta);
            this.groupBoxPacijenti.Location = new System.Drawing.Point(310, 30);
            this.groupBoxPacijenti.Name = "groupBoxPacijenti";
            this.groupBoxPacijenti.Size = new System.Drawing.Size(346, 345);
            this.groupBoxPacijenti.TabIndex = 3;
            this.groupBoxPacijenti.TabStop = false;
            this.groupBoxPacijenti.Text = "Pregled pacijenata";
            // 
            // labelPretraga
            // 
            this.labelPretraga.AutoSize = true;
            this.labelPretraga.Location = new System.Drawing.Point(30, 44);
            this.labelPretraga.Name = "labelPretraga";
            this.labelPretraga.Size = new System.Drawing.Size(87, 14);
            this.labelPretraga.TabIndex = 1;
            this.labelPretraga.Text = "Pretraga po:";
            // 
            // comboBoxPretraga
            // 
            this.comboBoxPretraga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPretraga.FormattingEnabled = true;
            this.comboBoxPretraga.Items.AddRange(new object[] {
            "ID",
            "JMBG",
            "Ime",
            "Prezime",
            "Ime i prezime"});
            this.comboBoxPretraga.Location = new System.Drawing.Point(176, 44);
            this.comboBoxPretraga.Name = "comboBoxPretraga";
            this.comboBoxPretraga.Size = new System.Drawing.Size(146, 22);
            this.comboBoxPretraga.TabIndex = 2;
            this.comboBoxPretraga.SelectedIndexChanged += new System.EventHandler(this.comboBoxPretraga_SelectedIndexChanged);
            // 
            // labelUnos
            // 
            this.labelUnos.AutoSize = true;
            this.labelUnos.Location = new System.Drawing.Point(30, 83);
            this.labelUnos.Name = "labelUnos";
            this.labelUnos.Size = new System.Drawing.Size(0, 14);
            this.labelUnos.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 4;
            // 
            // listBoxRezultatPretrage
            // 
            this.listBoxRezultatPretrage.FormattingEnabled = true;
            this.listBoxRezultatPretrage.ItemHeight = 14;
            this.listBoxRezultatPretrage.Location = new System.Drawing.Point(48, 158);
            this.listBoxRezultatPretrage.Name = "listBoxRezultatPretrage";
            this.listBoxRezultatPretrage.Size = new System.Drawing.Size(248, 88);
            this.listBoxRezultatPretrage.TabIndex = 5;
            this.listBoxRezultatPretrage.SelectedIndexChanged += new System.EventHandler(this.listBoxRezultatPretrage_SelectedIndexChanged);
            // 
            // buttonPretraga
            // 
            this.buttonPretraga.Location = new System.Drawing.Point(176, 118);
            this.buttonPretraga.Name = "buttonPretraga";
            this.buttonPretraga.Size = new System.Drawing.Size(75, 23);
            this.buttonPretraga.TabIndex = 6;
            this.buttonPretraga.Text = "Pretraži";
            this.buttonPretraga.UseVisualStyleBackColor = true;
            this.buttonPretraga.Click += new System.EventHandler(this.buttonPretraga_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(33, 285);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(124, 44);
            this.buttonObrisi.TabIndex = 7;
            this.buttonObrisi.Text = "Obriši pacijenta";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // labelNema
            // 
            this.labelNema.AutoSize = true;
            this.labelNema.ForeColor = System.Drawing.Color.Red;
            this.labelNema.Location = new System.Drawing.Point(48, 253);
            this.labelNema.Name = "labelNema";
            this.labelNema.Size = new System.Drawing.Size(0, 14);
            this.labelNema.TabIndex = 8;
            // 
            // UposlenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 400);
            this.Controls.Add(this.groupBoxPacijenti);
            this.Controls.Add(this.groupBoxOrdinacije);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UposlenikForma";
            this.Text = "Naša Mala Klinika";
            this.Load += new System.EventHandler(this.UposlenikForma_Load);
            this.groupBoxOrdinacije.ResumeLayout(false);
            this.groupBoxPacijenti.ResumeLayout(false);
            this.groupBoxPacijenti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistracijaPacijenta;
        private System.Windows.Forms.TreeView treeViewPacijenti;
        private System.Windows.Forms.GroupBox groupBoxOrdinacije;
        private System.Windows.Forms.GroupBox groupBoxPacijenti;
        private System.Windows.Forms.ListBox listBoxRezultatPretrage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelUnos;
        private System.Windows.Forms.ComboBox comboBoxPretraga;
        private System.Windows.Forms.Label labelPretraga;
        private System.Windows.Forms.Button buttonPretraga;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Label labelNema;
    }
}
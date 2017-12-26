namespace NasaMalaKlinika_WinFormApp
{
    partial class PacijentRegistracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacijentRegistracija));
            this.buttonRegistrujSe = new System.Windows.Forms.Button();
            this.buttonPonisti = new System.Windows.Forms.Button();
            this.groupBoxLicni = new System.Windows.Forms.GroupBox();
            this.slikaDatum1 = new NasaMalaKlinika_WinFormApp.SlikaDatum();
            this.labelIme = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.textBoxPotvrda = new System.Windows.Forms.TextBox();
            this.labelPotvrda = new System.Windows.Forms.Label();
            this.buttonPrikazPass = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelDatumRod = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxBrStanje = new System.Windows.Forms.ComboBox();
            this.labelBrStanje = new System.Windows.Forms.Label();
            this.groupBoxSpol = new System.Windows.Forms.GroupBox();
            this.radioButtonZensko = new System.Windows.Forms.RadioButton();
            this.radioButtonMusko = new System.Windows.Forms.RadioButton();
            this.labelJmbg = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.groupBoxZakazivanje = new System.Windows.Forms.GroupBox();
            this.textBoxUzrokSmrti = new System.Windows.Forms.TextBox();
            this.textBoxPrvaPomoc = new System.Windows.Forms.TextBox();
            this.labelUzrokSmrti = new System.Windows.Forms.Label();
            this.labelPrvaPomoc = new System.Windows.Forms.Label();
            this.labelZakazi = new System.Windows.Forms.Label();
            this.checkedListBoxOrdinacije = new System.Windows.Forms.CheckedListBox();
            this.groupBoxStanje = new System.Windows.Forms.GroupBox();
            this.radioButtonSmrtni = new System.Windows.Forms.RadioButton();
            this.radioButtonHitni = new System.Windows.Forms.RadioButton();
            this.radioButtonNormalni = new System.Windows.Forms.RadioButton();
            this.groupBoxLicni.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxSpol.SuspendLayout();
            this.groupBoxZakazivanje.SuspendLayout();
            this.groupBoxStanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegistrujSe
            // 
            this.buttonRegistrujSe.Location = new System.Drawing.Point(560, 410);
            this.buttonRegistrujSe.Name = "buttonRegistrujSe";
            this.buttonRegistrujSe.Size = new System.Drawing.Size(300, 32);
            this.buttonRegistrujSe.TabIndex = 19;
            this.buttonRegistrujSe.Text = "Registracija";
            this.buttonRegistrujSe.UseVisualStyleBackColor = true;
            this.buttonRegistrujSe.Click += new System.EventHandler(this.buttonRegistrujSe_Click);
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.Location = new System.Drawing.Point(232, 410);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(300, 32);
            this.buttonPonisti.TabIndex = 18;
            this.buttonPonisti.Text = "Poništi";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            this.buttonPonisti.Click += new System.EventHandler(this.buttonPonisti_Click);
            // 
            // groupBoxLicni
            // 
            this.groupBoxLicni.Controls.Add(this.slikaDatum1);
            this.groupBoxLicni.Controls.Add(this.labelIme);
            this.groupBoxLicni.Controls.Add(this.textBox1);
            this.groupBoxLicni.Controls.Add(this.dateTimePicker1);
            this.groupBoxLicni.Controls.Add(this.groupBoxLogin);
            this.groupBoxLicni.Controls.Add(this.labelDatumRod);
            this.groupBoxLicni.Controls.Add(this.labelPrezime);
            this.groupBoxLicni.Controls.Add(this.textBox2);
            this.groupBoxLicni.Controls.Add(this.comboBoxBrStanje);
            this.groupBoxLicni.Controls.Add(this.labelBrStanje);
            this.groupBoxLicni.Controls.Add(this.groupBoxSpol);
            this.groupBoxLicni.Controls.Add(this.labelJmbg);
            this.groupBoxLicni.Controls.Add(this.textBoxAdresa);
            this.groupBoxLicni.Controls.Add(this.textBoxJMBG);
            this.groupBoxLicni.Controls.Add(this.labelAdresa);
            this.groupBoxLicni.Location = new System.Drawing.Point(232, 23);
            this.groupBoxLicni.Name = "groupBoxLicni";
            this.groupBoxLicni.Size = new System.Drawing.Size(628, 369);
            this.groupBoxLicni.TabIndex = 17;
            this.groupBoxLicni.TabStop = false;
            this.groupBoxLicni.Text = "Lični podaci";
            // 
            // slikaDatum1
            // 
            this.slikaDatum1.Location = new System.Drawing.Point(7, 101);
            this.slikaDatum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.slikaDatum1.Name = "slikaDatum1";
            this.slikaDatum1.Size = new System.Drawing.Size(273, 258);
            this.slikaDatum1.TabIndex = 12;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(21, 33);
            this.labelIme.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(36, 14);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.textBoxPotvrda);
            this.groupBoxLogin.Controls.Add(this.labelPotvrda);
            this.groupBoxLogin.Controls.Add(this.buttonPrikazPass);
            this.groupBoxLogin.Controls.Add(this.textBoxPass);
            this.groupBoxLogin.Controls.Add(this.textBoxUser);
            this.groupBoxLogin.Controls.Add(this.labelPass);
            this.groupBoxLogin.Controls.Add(this.labelUser);
            this.groupBoxLogin.Location = new System.Drawing.Point(287, 223);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(331, 136);
            this.groupBoxLogin.TabIndex = 16;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login podaci";
            // 
            // textBoxPotvrda
            // 
            this.textBoxPotvrda.Location = new System.Drawing.Point(128, 98);
            this.textBoxPotvrda.Name = "textBoxPotvrda";
            this.textBoxPotvrda.PasswordChar = '*';
            this.textBoxPotvrda.Size = new System.Drawing.Size(175, 22);
            this.textBoxPotvrda.TabIndex = 9;
            // 
            // labelPotvrda
            // 
            this.labelPotvrda.AutoSize = true;
            this.labelPotvrda.Location = new System.Drawing.Point(21, 98);
            this.labelPotvrda.Name = "labelPotvrda";
            this.labelPotvrda.Size = new System.Drawing.Size(104, 14);
            this.labelPotvrda.TabIndex = 8;
            this.labelPotvrda.Text = "Potvrdi lozinku:";
            // 
            // buttonPrikazPass
            // 
            this.buttonPrikazPass.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrikazPass.Image")));
            this.buttonPrikazPass.Location = new System.Drawing.Point(277, 65);
            this.buttonPrikazPass.Name = "buttonPrikazPass";
            this.buttonPrikazPass.Size = new System.Drawing.Size(26, 22);
            this.buttonPrikazPass.TabIndex = 7;
            this.buttonPrikazPass.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(128, 65);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(175, 22);
            this.textBoxPass.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(128, 30);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(175, 22);
            this.textBoxUser.TabIndex = 2;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(21, 64);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(60, 14);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Lozinka:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(21, 33);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(101, 14);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Korisničko ime:";
            // 
            // labelDatumRod
            // 
            this.labelDatumRod.AutoSize = true;
            this.labelDatumRod.Location = new System.Drawing.Point(292, 185);
            this.labelDatumRod.Name = "labelDatumRod";
            this.labelDatumRod.Size = new System.Drawing.Size(106, 14);
            this.labelDatumRod.TabIndex = 11;
            this.labelDatumRod.Text = "Datum rođenja:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(21, 64);
            this.labelPrezime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(62, 14);
            this.labelPrezime.TabIndex = 1;
            this.labelPrezime.Text = "Prezime:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 3;
            // 
            // comboBoxBrStanje
            // 
            this.comboBoxBrStanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrStanje.Items.AddRange(new object[] {
            "Oženjen",
            "Neoženjen",
            "Razveden",
            "Udovac"});
            this.comboBoxBrStanje.Location = new System.Drawing.Point(415, 154);
            this.comboBoxBrStanje.Name = "comboBoxBrStanje";
            this.comboBoxBrStanje.Size = new System.Drawing.Size(192, 22);
            this.comboBoxBrStanje.TabIndex = 0;
            // 
            // labelBrStanje
            // 
            this.labelBrStanje.AutoSize = true;
            this.labelBrStanje.Location = new System.Drawing.Point(292, 154);
            this.labelBrStanje.Name = "labelBrStanje";
            this.labelBrStanje.Size = new System.Drawing.Size(99, 14);
            this.labelBrStanje.TabIndex = 9;
            this.labelBrStanje.Text = "Bračno stanje:";
            // 
            // groupBoxSpol
            // 
            this.groupBoxSpol.Controls.Add(this.radioButtonZensko);
            this.groupBoxSpol.Controls.Add(this.radioButtonMusko);
            this.groupBoxSpol.Location = new System.Drawing.Point(287, 24);
            this.groupBoxSpol.Name = "groupBoxSpol";
            this.groupBoxSpol.Size = new System.Drawing.Size(260, 54);
            this.groupBoxSpol.TabIndex = 4;
            this.groupBoxSpol.TabStop = false;
            this.groupBoxSpol.Text = "Spol";
            // 
            // radioButtonZensko
            // 
            this.radioButtonZensko.AutoSize = true;
            this.radioButtonZensko.Location = new System.Drawing.Point(136, 22);
            this.radioButtonZensko.Name = "radioButtonZensko";
            this.radioButtonZensko.Size = new System.Drawing.Size(71, 18);
            this.radioButtonZensko.TabIndex = 1;
            this.radioButtonZensko.TabStop = true;
            this.radioButtonZensko.Text = "Žensko";
            this.radioButtonZensko.UseVisualStyleBackColor = true;
            this.radioButtonZensko.CheckedChanged += new System.EventHandler(this.radioButtonZensko_CheckedChanged);
            // 
            // radioButtonMusko
            // 
            this.radioButtonMusko.AutoSize = true;
            this.radioButtonMusko.Location = new System.Drawing.Point(51, 22);
            this.radioButtonMusko.Name = "radioButtonMusko";
            this.radioButtonMusko.Size = new System.Drawing.Size(65, 18);
            this.radioButtonMusko.TabIndex = 0;
            this.radioButtonMusko.TabStop = true;
            this.radioButtonMusko.Text = "Muško";
            this.radioButtonMusko.UseVisualStyleBackColor = true;
            this.radioButtonMusko.CheckedChanged += new System.EventHandler(this.radioButtonMusko_CheckedChanged);
            // 
            // labelJmbg
            // 
            this.labelJmbg.AutoSize = true;
            this.labelJmbg.Location = new System.Drawing.Point(292, 94);
            this.labelJmbg.Name = "labelJmbg";
            this.labelJmbg.Size = new System.Drawing.Size(44, 14);
            this.labelJmbg.TabIndex = 5;
            this.labelJmbg.Text = "JMBG:";
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(415, 126);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(192, 22);
            this.textBoxAdresa.TabIndex = 8;
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(415, 94);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(192, 22);
            this.textBoxJMBG.TabIndex = 7;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(292, 124);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(56, 14);
            this.labelAdresa.TabIndex = 6;
            this.labelAdresa.Text = "Adresa:";
            // 
            // groupBoxZakazivanje
            // 
            this.groupBoxZakazivanje.Controls.Add(this.textBoxUzrokSmrti);
            this.groupBoxZakazivanje.Controls.Add(this.textBoxPrvaPomoc);
            this.groupBoxZakazivanje.Controls.Add(this.labelUzrokSmrti);
            this.groupBoxZakazivanje.Controls.Add(this.labelPrvaPomoc);
            this.groupBoxZakazivanje.Controls.Add(this.labelZakazi);
            this.groupBoxZakazivanje.Controls.Add(this.checkedListBoxOrdinacije);
            this.groupBoxZakazivanje.Controls.Add(this.groupBoxStanje);
            this.groupBoxZakazivanje.Location = new System.Drawing.Point(26, 23);
            this.groupBoxZakazivanje.Name = "groupBoxZakazivanje";
            this.groupBoxZakazivanje.Size = new System.Drawing.Size(181, 419);
            this.groupBoxZakazivanje.TabIndex = 20;
            this.groupBoxZakazivanje.TabStop = false;
            this.groupBoxZakazivanje.Text = "Podaci o prijemu";
            // 
            // textBoxUzrokSmrti
            // 
            this.textBoxUzrokSmrti.Location = new System.Drawing.Point(24, 229);
            this.textBoxUzrokSmrti.Name = "textBoxUzrokSmrti";
            this.textBoxUzrokSmrti.Size = new System.Drawing.Size(129, 22);
            this.textBoxUzrokSmrti.TabIndex = 6;
            // 
            // textBoxPrvaPomoc
            // 
            this.textBoxPrvaPomoc.Location = new System.Drawing.Point(24, 174);
            this.textBoxPrvaPomoc.Name = "textBoxPrvaPomoc";
            this.textBoxPrvaPomoc.Size = new System.Drawing.Size(129, 22);
            this.textBoxPrvaPomoc.TabIndex = 5;
            // 
            // labelUzrokSmrti
            // 
            this.labelUzrokSmrti.AutoSize = true;
            this.labelUzrokSmrti.Location = new System.Drawing.Point(21, 212);
            this.labelUzrokSmrti.Name = "labelUzrokSmrti";
            this.labelUzrokSmrti.Size = new System.Drawing.Size(83, 14);
            this.labelUzrokSmrti.TabIndex = 4;
            this.labelUzrokSmrti.Text = "Uzrok smrti:";
            // 
            // labelPrvaPomoc
            // 
            this.labelPrvaPomoc.AutoSize = true;
            this.labelPrvaPomoc.Location = new System.Drawing.Point(25, 157);
            this.labelPrvaPomoc.Name = "labelPrvaPomoc";
            this.labelPrvaPomoc.Size = new System.Drawing.Size(85, 14);
            this.labelPrvaPomoc.TabIndex = 3;
            this.labelPrvaPomoc.Text = "Prva pomoć:";
            // 
            // labelZakazi
            // 
            this.labelZakazi.AutoSize = true;
            this.labelZakazi.Location = new System.Drawing.Point(25, 274);
            this.labelZakazi.Name = "labelZakazi";
            this.labelZakazi.Size = new System.Drawing.Size(131, 14);
            this.labelZakazi.TabIndex = 2;
            this.labelZakazi.Text = "Zakažite pregled(e)";
            // 
            // checkedListBoxOrdinacije
            // 
            this.checkedListBoxOrdinacije.FormattingEnabled = true;
            this.checkedListBoxOrdinacije.Location = new System.Drawing.Point(6, 290);
            this.checkedListBoxOrdinacije.Name = "checkedListBoxOrdinacije";
            this.checkedListBoxOrdinacije.Size = new System.Drawing.Size(169, 123);
            this.checkedListBoxOrdinacije.TabIndex = 1;
            // 
            // groupBoxStanje
            // 
            this.groupBoxStanje.Controls.Add(this.radioButtonSmrtni);
            this.groupBoxStanje.Controls.Add(this.radioButtonHitni);
            this.groupBoxStanje.Controls.Add(this.radioButtonNormalni);
            this.groupBoxStanje.Location = new System.Drawing.Point(24, 28);
            this.groupBoxStanje.Name = "groupBoxStanje";
            this.groupBoxStanje.Size = new System.Drawing.Size(132, 112);
            this.groupBoxStanje.TabIndex = 0;
            this.groupBoxStanje.TabStop = false;
            this.groupBoxStanje.Text = "Stanje";
            // 
            // radioButtonSmrtni
            // 
            this.radioButtonSmrtni.AutoSize = true;
            this.radioButtonSmrtni.Location = new System.Drawing.Point(7, 70);
            this.radioButtonSmrtni.Name = "radioButtonSmrtni";
            this.radioButtonSmrtni.Size = new System.Drawing.Size(105, 18);
            this.radioButtonSmrtni.TabIndex = 2;
            this.radioButtonSmrtni.TabStop = true;
            this.radioButtonSmrtni.Text = "Smrtni slučaj";
            this.radioButtonSmrtni.UseVisualStyleBackColor = true;
            this.radioButtonSmrtni.CheckedChanged += new System.EventHandler(this.radioButtonSmrtni_CheckedChanged);
            // 
            // radioButtonHitni
            // 
            this.radioButtonHitni.AutoSize = true;
            this.radioButtonHitni.Location = new System.Drawing.Point(7, 47);
            this.radioButtonHitni.Name = "radioButtonHitni";
            this.radioButtonHitni.Size = new System.Drawing.Size(107, 18);
            this.radioButtonHitni.TabIndex = 1;
            this.radioButtonHitni.TabStop = true;
            this.radioButtonHitni.Text = "Hitni pacijent";
            this.radioButtonHitni.UseVisualStyleBackColor = true;
            this.radioButtonHitni.CheckedChanged += new System.EventHandler(this.radioButtonHitni_CheckedChanged);
            // 
            // radioButtonNormalni
            // 
            this.radioButtonNormalni.AutoSize = true;
            this.radioButtonNormalni.Location = new System.Drawing.Point(7, 22);
            this.radioButtonNormalni.Name = "radioButtonNormalni";
            this.radioButtonNormalni.Size = new System.Drawing.Size(117, 18);
            this.radioButtonNormalni.TabIndex = 0;
            this.radioButtonNormalni.TabStop = true;
            this.radioButtonNormalni.Text = "Obični pacijent";
            this.radioButtonNormalni.UseVisualStyleBackColor = true;
            this.radioButtonNormalni.CheckedChanged += new System.EventHandler(this.radioButtonNormalni_CheckedChanged);
            // 
            // PacijentRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 476);
            this.Controls.Add(this.groupBoxZakazivanje);
            this.Controls.Add(this.buttonRegistrujSe);
            this.Controls.Add(this.buttonPonisti);
            this.Controls.Add(this.groupBoxLicni);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "PacijentRegistracija";
            this.Text = "Naša Mala Klinika";
            this.Load += new System.EventHandler(this.PacijentRegistracija_Load);
            this.groupBoxLicni.ResumeLayout(false);
            this.groupBoxLicni.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxSpol.ResumeLayout(false);
            this.groupBoxSpol.PerformLayout();
            this.groupBoxZakazivanje.ResumeLayout(false);
            this.groupBoxZakazivanje.PerformLayout();
            this.groupBoxStanje.ResumeLayout(false);
            this.groupBoxStanje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrujSe;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.GroupBox groupBoxLicni;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDatumRod;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxBrStanje;
        private System.Windows.Forms.Label labelBrStanje;
        private System.Windows.Forms.GroupBox groupBoxSpol;
        private System.Windows.Forms.RadioButton radioButtonZensko;
        private System.Windows.Forms.RadioButton radioButtonMusko;
        private System.Windows.Forms.Label labelJmbg;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TextBox textBoxPotvrda;
        private System.Windows.Forms.Label labelPotvrda;
        private System.Windows.Forms.Button buttonPrikazPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxZakazivanje;
        private SlikaDatum slikaDatum1;
        private System.Windows.Forms.TextBox textBoxUzrokSmrti;
        private System.Windows.Forms.TextBox textBoxPrvaPomoc;
        private System.Windows.Forms.Label labelUzrokSmrti;
        private System.Windows.Forms.Label labelPrvaPomoc;
        private System.Windows.Forms.Label labelZakazi;
        private System.Windows.Forms.CheckedListBox checkedListBoxOrdinacije;
        private System.Windows.Forms.GroupBox groupBoxStanje;
        private System.Windows.Forms.RadioButton radioButtonSmrtni;
        private System.Windows.Forms.RadioButton radioButtonHitni;
        private System.Windows.Forms.RadioButton radioButtonNormalni;
    }
}
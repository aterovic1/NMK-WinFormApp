using System.Collections.Generic;
using System.Windows.Forms;

namespace NasaMalaKlinika_WinFormApp
{
    partial class Registracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registracija));
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxSpol = new System.Windows.Forms.GroupBox();
            this.radioButtonZensko = new System.Windows.Forms.RadioButton();
            this.radioButtonMusko = new System.Windows.Forms.RadioButton();
            this.labelJmbg = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.comboBoxBrStanje = new System.Windows.Forms.ComboBox();
            this.labelBrStanje = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDatumRod = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonPrikazPass = new System.Windows.Forms.Button();
            this.radioButtonObicni = new System.Windows.Forms.RadioButton();
            this.radioButtonDoktor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxLicni = new System.Windows.Forms.GroupBox();
            this.labelPotvrda = new System.Windows.Forms.Label();
            this.textBoxPotvrda = new System.Windows.Forms.TextBox();
            this.buttonPonisti = new System.Windows.Forms.Button();
            this.buttonRegistrujSe = new System.Windows.Forms.Button();
            this.comboBoxOrdinacije = new System.Windows.Forms.ComboBox();
            this.labelOrdinacija = new System.Windows.Forms.Label();
            this.groupBoxSpol.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxLicni.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(20, 33);
            this.labelIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(36, 14);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(20, 64);
            this.labelPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(62, 14);
            this.labelPrezime.TabIndex = 1;
            this.labelPrezime.Text = "Prezime:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 65);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 3;
            // 
            // groupBoxSpol
            // 
            this.groupBoxSpol.Controls.Add(this.radioButtonZensko);
            this.groupBoxSpol.Controls.Add(this.radioButtonMusko);
            this.groupBoxSpol.Location = new System.Drawing.Point(23, 111);
            this.groupBoxSpol.Name = "groupBoxSpol";
            this.groupBoxSpol.Size = new System.Drawing.Size(259, 90);
            this.groupBoxSpol.TabIndex = 4;
            this.groupBoxSpol.TabStop = false;
            this.groupBoxSpol.Text = "Spol";
            // 
            // radioButtonZensko
            // 
            this.radioButtonZensko.AutoSize = true;
            this.radioButtonZensko.Location = new System.Drawing.Point(109, 55);
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
            this.radioButtonMusko.Location = new System.Drawing.Point(109, 21);
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
            this.labelJmbg.Location = new System.Drawing.Point(20, 224);
            this.labelJmbg.Name = "labelJmbg";
            this.labelJmbg.Size = new System.Drawing.Size(44, 14);
            this.labelJmbg.TabIndex = 5;
            this.labelJmbg.Text = "JMBG:";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(20, 257);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(56, 14);
            this.labelAdresa.TabIndex = 6;
            this.labelAdresa.Text = "Adresa:";
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(132, 224);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(150, 22);
            this.textBoxJMBG.TabIndex = 7;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(132, 257);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(150, 22);
            this.textBoxAdresa.TabIndex = 8;
            // 
            // comboBoxBrStanje
            // 
            this.comboBoxBrStanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrStanje.Items.AddRange(new object[] {
            "Oženjen",
            "Neoženjen",
            "Razveden",
            "Udovac"});
            this.comboBoxBrStanje.Location = new System.Drawing.Point(132, 291);
            this.comboBoxBrStanje.Name = "comboBoxBrStanje";
            this.comboBoxBrStanje.Size = new System.Drawing.Size(150, 22);
            this.comboBoxBrStanje.TabIndex = 0;
            // 
            // labelBrStanje
            // 
            this.labelBrStanje.AutoSize = true;
            this.labelBrStanje.Location = new System.Drawing.Point(20, 291);
            this.labelBrStanje.Name = "labelBrStanje";
            this.labelBrStanje.Size = new System.Drawing.Size(99, 14);
            this.labelBrStanje.TabIndex = 9;
            this.labelBrStanje.Text = "Bračno stanje:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 322);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // labelDatumRod
            // 
            this.labelDatumRod.AutoSize = true;
            this.labelDatumRod.Location = new System.Drawing.Point(20, 322);
            this.labelDatumRod.Name = "labelDatumRod";
            this.labelDatumRod.Size = new System.Drawing.Size(106, 14);
            this.labelDatumRod.TabIndex = 11;
            this.labelDatumRod.Text = "Datum rođenja:";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.labelOrdinacija);
            this.groupBoxLogin.Controls.Add(this.comboBoxOrdinacije);
            this.groupBoxLogin.Controls.Add(this.textBoxPotvrda);
            this.groupBoxLogin.Controls.Add(this.labelPotvrda);
            this.groupBoxLogin.Controls.Add(this.buttonPrikazPass);
            this.groupBoxLogin.Controls.Add(this.radioButtonObicni);
            this.groupBoxLogin.Controls.Add(this.radioButtonDoktor);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.textBoxPass);
            this.groupBoxLogin.Controls.Add(this.textBoxUser);
            this.groupBoxLogin.Controls.Add(this.labelPass);
            this.groupBoxLogin.Controls.Add(this.labelUser);
            this.groupBoxLogin.Location = new System.Drawing.Point(430, 30);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(320, 320);
            this.groupBoxLogin.TabIndex = 12;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login podaci";
            // 
            // buttonPrikazPass
            // 
            this.buttonPrikazPass.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrikazPass.Image")));
            this.buttonPrikazPass.Location = new System.Drawing.Point(286, 64);
            this.buttonPrikazPass.Name = "buttonPrikazPass";
            this.buttonPrikazPass.Size = new System.Drawing.Size(26, 22);
            this.buttonPrikazPass.TabIndex = 7;
            this.buttonPrikazPass.UseVisualStyleBackColor = true;
            this.buttonPrikazPass.Click += new System.EventHandler(this.buttonPrikazPass_Click);
            // 
            // radioButtonObicni
            // 
            this.radioButtonObicni.AutoSize = true;
            this.radioButtonObicni.Location = new System.Drawing.Point(143, 183);
            this.radioButtonObicni.Name = "radioButtonObicni";
            this.radioButtonObicni.Size = new System.Drawing.Size(154, 18);
            this.radioButtonObicni.TabIndex = 6;
            this.radioButtonObicni.TabStop = true;
            this.radioButtonObicni.Text = "Nemedicinska osoba";
            this.radioButtonObicni.UseVisualStyleBackColor = true;
            this.radioButtonObicni.CheckedChanged += new System.EventHandler(this.radioButtonObicni_CheckedChanged);
            // 
            // radioButtonDoktor
            // 
            this.radioButtonDoktor.AutoSize = true;
            this.radioButtonDoktor.Location = new System.Drawing.Point(143, 154);
            this.radioButtonDoktor.Name = "radioButtonDoktor";
            this.radioButtonDoktor.Size = new System.Drawing.Size(67, 18);
            this.radioButtonDoktor.TabIndex = 5;
            this.radioButtonDoktor.TabStop = true;
            this.radioButtonDoktor.Text = "Doktor";
            this.radioButtonDoktor.UseVisualStyleBackColor = true;
            this.radioButtonDoktor.CheckedChanged += new System.EventHandler(this.radioButtonDoktor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ja sam:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(143, 64);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(139, 22);
            this.textBoxPass.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(143, 33);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(139, 22);
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
            // groupBoxLicni
            // 
            this.groupBoxLicni.Controls.Add(this.labelIme);
            this.groupBoxLicni.Controls.Add(this.textBox1);
            this.groupBoxLicni.Controls.Add(this.dateTimePicker1);
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
            this.groupBoxLicni.Location = new System.Drawing.Point(30, 30);
            this.groupBoxLicni.Name = "groupBoxLicni";
            this.groupBoxLicni.Size = new System.Drawing.Size(385, 363);
            this.groupBoxLicni.TabIndex = 13;
            this.groupBoxLicni.TabStop = false;
            this.groupBoxLicni.Text = "Lični podaci";
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
            // textBoxPotvrda
            // 
            this.textBoxPotvrda.Location = new System.Drawing.Point(143, 98);
            this.textBoxPotvrda.Name = "textBoxPotvrda";
            this.textBoxPotvrda.PasswordChar = '*';
            this.textBoxPotvrda.Size = new System.Drawing.Size(139, 22);
            this.textBoxPotvrda.TabIndex = 9;
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.Location = new System.Drawing.Point(430, 361);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(145, 32);
            this.buttonPonisti.TabIndex = 14;
            this.buttonPonisti.Text = "Poništi";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            this.buttonPonisti.Click += new System.EventHandler(this.buttonPonisti_Click);
            // 
            // buttonRegistrujSe
            // 
            this.buttonRegistrujSe.Location = new System.Drawing.Point(605, 361);
            this.buttonRegistrujSe.Name = "buttonRegistrujSe";
            this.buttonRegistrujSe.Size = new System.Drawing.Size(145, 32);
            this.buttonRegistrujSe.TabIndex = 15;
            this.buttonRegistrujSe.Text = "Registruj se";
            this.buttonRegistrujSe.UseVisualStyleBackColor = true;
            this.buttonRegistrujSe.Click += new System.EventHandler(this.buttonRegistrujSe_Click);
            // 
            // comboBoxOrdinacije
            // 
            this.comboBoxOrdinacije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdinacije.DropDownWidth = 175;
            this.comboBoxOrdinacije.Enabled = false;
            this.comboBoxOrdinacije.FormattingEnabled = true;
            this.comboBoxOrdinacije.Items.AddRange(new object[] {
            "Opšti pregled",
            "Kardiološki pregled",
            "Dermatološki pregled",
            "Ortopedski pregled",
            "Internistički pregled",
            "Otorinolaringološki pregled",
            "Oftamološki pregled",
            "Laboratorijski pregled",
            "Stomatološki pregled"});
            this.comboBoxOrdinacije.Location = new System.Drawing.Point(143, 232);
            this.comboBoxOrdinacije.Name = "comboBoxOrdinacije";
            this.comboBoxOrdinacije.Size = new System.Drawing.Size(139, 22);
            this.comboBoxOrdinacije.TabIndex = 10;
            // 
            // labelOrdinacija
            // 
            this.labelOrdinacija.AutoSize = true;
            this.labelOrdinacija.Enabled = false;
            this.labelOrdinacija.Location = new System.Drawing.Point(21, 232);
            this.labelOrdinacija.Name = "labelOrdinacija";
            this.labelOrdinacija.Size = new System.Drawing.Size(94, 14);
            this.labelOrdinacija.TabIndex = 11;
            this.labelOrdinacija.Text = "Ordinacija za:";
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 428);
            this.Controls.Add(this.buttonRegistrujSe);
            this.Controls.Add(this.buttonPonisti);
            this.Controls.Add(this.groupBoxLicni);
            this.Controls.Add(this.groupBoxLogin);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Registracija";
            this.Text = "Registracija";
            this.groupBoxSpol.ResumeLayout(false);
            this.groupBoxSpol.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxLicni.ResumeLayout(false);
            this.groupBoxLicni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxSpol;
        private System.Windows.Forms.RadioButton radioButtonZensko;
        private System.Windows.Forms.RadioButton radioButtonMusko;
        private System.Windows.Forms.Label labelJmbg;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label labelBrStanje;
        private System.Windows.Forms.ComboBox comboBoxBrStanje;
        private DateTimePicker dateTimePicker1;
        private Label labelDatumRod;
        private GroupBox groupBoxLogin;
        private TextBox textBoxPass;
        private TextBox textBoxUser;
        private Label labelPass;
        private Label labelUser;
        private Button buttonPrikazPass;
        private RadioButton radioButtonObicni;
        private RadioButton radioButtonDoktor;
        private Label label1;
        private GroupBox groupBoxLicni;
        private TextBox textBoxPotvrda;
        private Label labelPotvrda;
        private Button buttonPonisti;
        private Button buttonRegistrujSe;
        private Label labelOrdinacija;
        private ComboBox comboBoxOrdinacije;
    }
}
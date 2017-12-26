using NasaMalaKlinika;
using System.Windows.Forms;

namespace NasaMalaKlinika_WinFormApp
{
    partial class DoktorForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podešavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojaOrdinacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.našaMalaKllinikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlPregledi = new System.Windows.Forms.TabControl();
            this.tabPageZakazani = new System.Windows.Forms.TabPage();
            this.labelNemaPregleda = new System.Windows.Forms.Label();
            this.buttonObaviPregled = new System.Windows.Forms.Button();
            this.richTextBoxPacijentDetaljno = new System.Windows.Forms.RichTextBox();
            this.listViewZakazani = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxDetaljno = new System.Windows.Forms.RichTextBox();
            this.listViewObavljeni = new System.Windows.Forms.ListView();
            this.labelObavijest = new System.Windows.Forms.Label();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Starost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabControlPregledi.SuspendLayout();
            this.tabPageZakazani.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podešavanjaToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.profilToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profilToolStripMenuItem.Image")));
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // podešavanjaToolStripMenuItem
            // 
            this.podešavanjaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("podešavanjaToolStripMenuItem.Image")));
            this.podešavanjaToolStripMenuItem.Name = "podešavanjaToolStripMenuItem";
            this.podešavanjaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.podešavanjaToolStripMenuItem.Text = "Podešavanja";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("odjavaToolStripMenuItem.Image")));
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojaOrdinacijaToolStripMenuItem,
            this.našaMalaKllinikaToolStripMenuItem});
            this.statistikaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistikaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statistikaToolStripMenuItem.Image")));
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // mojaOrdinacijaToolStripMenuItem
            // 
            this.mojaOrdinacijaToolStripMenuItem.Name = "mojaOrdinacijaToolStripMenuItem";
            this.mojaOrdinacijaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.mojaOrdinacijaToolStripMenuItem.Text = "Moja ordinacija ";
            // 
            // našaMalaKllinikaToolStripMenuItem
            // 
            this.našaMalaKllinikaToolStripMenuItem.Name = "našaMalaKllinikaToolStripMenuItem";
            this.našaMalaKllinikaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.našaMalaKllinikaToolStripMenuItem.Text = "Naša Mala Kllinika";
            this.našaMalaKllinikaToolStripMenuItem.Click += new System.EventHandler(this.našaMalaKllinikaToolStripMenuItem_Click);
            // 
            // tabControlPregledi
            // 
            this.tabControlPregledi.Controls.Add(this.tabPageZakazani);
            this.tabControlPregledi.Controls.Add(this.tabPage2);
            this.tabControlPregledi.Location = new System.Drawing.Point(12, 27);
            this.tabControlPregledi.Name = "tabControlPregledi";
            this.tabControlPregledi.SelectedIndex = 0;
            this.tabControlPregledi.Size = new System.Drawing.Size(660, 322);
            this.tabControlPregledi.TabIndex = 1;
            // 
            // tabPageZakazani
            // 
            this.tabPageZakazani.Controls.Add(this.labelNemaPregleda);
            this.tabPageZakazani.Controls.Add(this.buttonObaviPregled);
            this.tabPageZakazani.Controls.Add(this.richTextBoxPacijentDetaljno);
            this.tabPageZakazani.Controls.Add(this.listViewZakazani);
            this.tabPageZakazani.Location = new System.Drawing.Point(4, 23);
            this.tabPageZakazani.Name = "tabPageZakazani";
            this.tabPageZakazani.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZakazani.Size = new System.Drawing.Size(652, 295);
            this.tabPageZakazani.TabIndex = 0;
            this.tabPageZakazani.Text = "Zakazani pregledi";
            this.tabPageZakazani.UseVisualStyleBackColor = true;
            this.tabPageZakazani.Leave += new System.EventHandler(this.tabPageZakazani_Leave);
            // 
            // labelNemaPregleda
            // 
            this.labelNemaPregleda.AutoSize = true;
            this.labelNemaPregleda.ForeColor = System.Drawing.Color.Red;
            this.labelNemaPregleda.Location = new System.Drawing.Point(22, 16);
            this.labelNemaPregleda.Name = "labelNemaPregleda";
            this.labelNemaPregleda.Size = new System.Drawing.Size(0, 14);
            this.labelNemaPregleda.TabIndex = 4;
            // 
            // buttonObaviPregled
            // 
            this.buttonObaviPregled.BackColor = System.Drawing.SystemColors.Control;
            this.buttonObaviPregled.Enabled = false;
            this.buttonObaviPregled.Location = new System.Drawing.Point(242, 213);
            this.buttonObaviPregled.Name = "buttonObaviPregled";
            this.buttonObaviPregled.Size = new System.Drawing.Size(155, 43);
            this.buttonObaviPregled.TabIndex = 3;
            this.buttonObaviPregled.Text = "Obavi pregled";
            this.buttonObaviPregled.UseVisualStyleBackColor = false;
            this.buttonObaviPregled.Click += new System.EventHandler(this.buttonObaviPregled_Click);
            // 
            // richTextBoxPacijentDetaljno
            // 
            this.richTextBoxPacijentDetaljno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxPacijentDetaljno.Location = new System.Drawing.Point(423, 47);
            this.richTextBoxPacijentDetaljno.Name = "richTextBoxPacijentDetaljno";
            this.richTextBoxPacijentDetaljno.ReadOnly = true;
            this.richTextBoxPacijentDetaljno.Size = new System.Drawing.Size(192, 130);
            this.richTextBoxPacijentDetaljno.TabIndex = 2;
            this.richTextBoxPacijentDetaljno.Text = "";
            // 
            // listViewZakazani
            // 
            this.listViewZakazani.AllowColumnReorder = true;
            this.listViewZakazani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listViewZakazani.FullRowSelect = true;
            this.listViewZakazani.GridLines = true;
            this.listViewZakazani.Location = new System.Drawing.Point(22, 47);
            this.listViewZakazani.Name = "listViewZakazani";
            this.listViewZakazani.Size = new System.Drawing.Size(375, 130);
            this.listViewZakazani.TabIndex = 1;
            this.listViewZakazani.UseCompatibleStateImageBehavior = false;
            this.listViewZakazani.View = System.Windows.Forms.View.Details;
            this.listViewZakazani.SelectedIndexChanged += new System.EventHandler(this.listViewZakazani_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxDetaljno);
            this.tabPage2.Controls.Add(this.listViewObavljeni);
            this.tabPage2.Controls.Add(this.labelObavijest);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obavljeni pregledi";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Leave += new System.EventHandler(this.tabPage2_Leave);
            // 
            // richTextBoxDetaljno
            // 
            this.richTextBoxDetaljno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxDetaljno.Location = new System.Drawing.Point(423, 47);
            this.richTextBoxDetaljno.Name = "richTextBoxDetaljno";
            this.richTextBoxDetaljno.ReadOnly = true;
            this.richTextBoxDetaljno.Size = new System.Drawing.Size(192, 130);
            this.richTextBoxDetaljno.TabIndex = 2;
            this.richTextBoxDetaljno.Text = "";
            // 
            // listViewObavljeni
            // 
            this.listViewObavljeni.AllowColumnReorder = true;
            this.listViewObavljeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listViewObavljeni.FullRowSelect = true;
            this.listViewObavljeni.GridLines = true;
            this.listViewObavljeni.Location = new System.Drawing.Point(22, 47);
            this.listViewObavljeni.Name = "listViewObavljeni";
            this.listViewObavljeni.Size = new System.Drawing.Size(375, 130);
            this.listViewObavljeni.TabIndex = 1;
            this.listViewObavljeni.UseCompatibleStateImageBehavior = false;
            this.listViewObavljeni.View = System.Windows.Forms.View.Details;
            this.listViewObavljeni.SelectedIndexChanged += new System.EventHandler(this.listViewObavljeni_SelectedIndexChanged);
            // 
            // labelObavijest
            // 
            this.labelObavijest.AutoSize = true;
            this.labelObavijest.ForeColor = System.Drawing.Color.Red;
            this.labelObavijest.Location = new System.Drawing.Point(29, 22);
            this.labelObavijest.Name = "labelObavijest";
            this.labelObavijest.Size = new System.Drawing.Size(0, 14);
            this.labelObavijest.TabIndex = 0;
            // 
            // DoktorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.tabControlPregledi);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DoktorForma";
            this.Text = "Naša Mala Klinika";
            this.Load += new System.EventHandler(this.DoktorForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlPregledi.ResumeLayout(false);
            this.tabPageZakazani.ResumeLayout(false);
            this.tabPageZakazani.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podešavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojaOrdinacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem našaMalaKllinikaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlPregledi;
        private System.Windows.Forms.TabPage tabPageZakazani;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Starost;
        private System.Windows.Forms.ListView listViewZakazani;
        private RichTextBox richTextBoxPacijentDetaljno;
        private Button buttonObaviPregled;
        private Label labelNemaPregleda;
        private ListView listViewObavljeni;
        private Label labelObavijest;
        private RichTextBox richTextBoxDetaljno;
    }
}
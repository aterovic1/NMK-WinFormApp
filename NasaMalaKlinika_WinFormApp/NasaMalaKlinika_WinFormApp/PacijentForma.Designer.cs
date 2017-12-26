namespace NasaMalaKlinika_WinFormApp
{
    partial class PacijentForma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacijentForma));
            this.groupBoxKarton = new System.Windows.Forms.GroupBox();
            this.richTextBoxKarton = new System.Windows.Forms.RichTextBox();
            this.groupBoxZakazani = new System.Windows.Forms.GroupBox();
            this.richTextBoxZakazani = new System.Windows.Forms.RichTextBox();
            this.groupBoxObavljeni = new System.Windows.Forms.GroupBox();
            this.richTextBoxObavljeni = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSlika = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPoruka = new System.Windows.Forms.Label();
            this.labelDug = new System.Windows.Forms.Label();
            this.labelImePrezime = new System.Windows.Forms.Label();
            this.ulijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.udesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxKarton.SuspendLayout();
            this.groupBoxZakazani.SuspendLayout();
            this.groupBoxObavljeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKarton
            // 
            this.groupBoxKarton.Controls.Add(this.richTextBoxKarton);
            this.groupBoxKarton.Location = new System.Drawing.Point(469, 203);
            this.groupBoxKarton.Name = "groupBoxKarton";
            this.groupBoxKarton.Size = new System.Drawing.Size(181, 90);
            this.groupBoxKarton.TabIndex = 0;
            this.groupBoxKarton.TabStop = false;
            this.groupBoxKarton.Text = "Moj karton";
            // 
            // richTextBoxKarton
            // 
            this.richTextBoxKarton.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxKarton.Location = new System.Drawing.Point(6, 21);
            this.richTextBoxKarton.Name = "richTextBoxKarton";
            this.richTextBoxKarton.Size = new System.Drawing.Size(169, 64);
            this.richTextBoxKarton.TabIndex = 0;
            this.richTextBoxKarton.Text = "";
            // 
            // groupBoxZakazani
            // 
            this.groupBoxZakazani.Controls.Add(this.richTextBoxZakazani);
            this.groupBoxZakazani.Location = new System.Drawing.Point(27, 35);
            this.groupBoxZakazani.Name = "groupBoxZakazani";
            this.groupBoxZakazani.Size = new System.Drawing.Size(200, 257);
            this.groupBoxZakazani.TabIndex = 1;
            this.groupBoxZakazani.TabStop = false;
            this.groupBoxZakazani.Text = "Zakazani pregledi";
            // 
            // richTextBoxZakazani
            // 
            this.richTextBoxZakazani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBoxZakazani.Location = new System.Drawing.Point(6, 21);
            this.richTextBoxZakazani.Name = "richTextBoxZakazani";
            this.richTextBoxZakazani.ReadOnly = true;
            this.richTextBoxZakazani.Size = new System.Drawing.Size(188, 230);
            this.richTextBoxZakazani.TabIndex = 0;
            this.richTextBoxZakazani.Text = "";
            // 
            // groupBoxObavljeni
            // 
            this.groupBoxObavljeni.Controls.Add(this.richTextBoxObavljeni);
            this.groupBoxObavljeni.Location = new System.Drawing.Point(246, 35);
            this.groupBoxObavljeni.Name = "groupBoxObavljeni";
            this.groupBoxObavljeni.Size = new System.Drawing.Size(200, 257);
            this.groupBoxObavljeni.TabIndex = 2;
            this.groupBoxObavljeni.TabStop = false;
            this.groupBoxObavljeni.Text = "Obavljeni pregledi";
            // 
            // richTextBoxObavljeni
            // 
            this.richTextBoxObavljeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBoxObavljeni.Location = new System.Drawing.Point(7, 22);
            this.richTextBoxObavljeni.Name = "richTextBoxObavljeni";
            this.richTextBoxObavljeni.Size = new System.Drawing.Size(187, 229);
            this.richTextBoxObavljeni.TabIndex = 0;
            this.richTextBoxObavljeni.Text = "";
            // 
            // pictureBoxSlika
            // 
            this.pictureBoxSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlika.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBoxSlika.Location = new System.Drawing.Point(495, 35);
            this.pictureBoxSlika.Name = "pictureBoxSlika";
            this.pictureBoxSlika.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxSlika.TabIndex = 3;
            this.pictureBoxSlika.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.rotirajToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripMenuItem.Image")));
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripMenuItem.Image")));
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // rotirajToolStripMenuItem
            // 
            this.rotirajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ulijevoToolStripMenuItem,
            this.udesnoToolStripMenuItem});
            this.rotirajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rotirajToolStripMenuItem.Image")));
            this.rotirajToolStripMenuItem.Name = "rotirajToolStripMenuItem";
            this.rotirajToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rotirajToolStripMenuItem.Text = "Rotiraj";
            // 
            // labelPoruka
            // 
            this.labelPoruka.AutoSize = true;
            this.labelPoruka.Location = new System.Drawing.Point(33, 316);
            this.labelPoruka.Name = "labelPoruka";
            this.labelPoruka.Size = new System.Drawing.Size(183, 14);
            this.labelPoruka.TabIndex = 4;
            this.labelPoruka.Text = "Vaš dug prema klinici iznosi:";
            // 
            // labelDug
            // 
            this.labelDug.AutoSize = true;
            this.labelDug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDug.Location = new System.Drawing.Point(223, 316);
            this.labelDug.Name = "labelDug";
            this.labelDug.Size = new System.Drawing.Size(0, 14);
            this.labelDug.TabIndex = 5;
            // 
            // labelImePrezime
            // 
            this.labelImePrezime.AutoSize = true;
            this.labelImePrezime.Location = new System.Drawing.Point(510, 175);
            this.labelImePrezime.Name = "labelImePrezime";
            this.labelImePrezime.Size = new System.Drawing.Size(0, 14);
            this.labelImePrezime.TabIndex = 6;
            // 
            // ulijevoToolStripMenuItem
            // 
            this.ulijevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ulijevoToolStripMenuItem.Image")));
            this.ulijevoToolStripMenuItem.Name = "ulijevoToolStripMenuItem";
            this.ulijevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ulijevoToolStripMenuItem.Text = "Ulijevo";
            this.ulijevoToolStripMenuItem.Click += new System.EventHandler(this.ulijevoToolStripMenuItem_Click);
            // 
            // udesnoToolStripMenuItem
            // 
            this.udesnoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("udesnoToolStripMenuItem.Image")));
            this.udesnoToolStripMenuItem.Name = "udesnoToolStripMenuItem";
            this.udesnoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.udesnoToolStripMenuItem.Text = "Udesno";
            this.udesnoToolStripMenuItem.Click += new System.EventHandler(this.udesnoToolStripMenuItem_Click);
            // 
            // PacijentForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 361);
            this.Controls.Add(this.labelImePrezime);
            this.Controls.Add(this.labelDug);
            this.Controls.Add(this.labelPoruka);
            this.Controls.Add(this.pictureBoxSlika);
            this.Controls.Add(this.groupBoxObavljeni);
            this.Controls.Add(this.groupBoxZakazani);
            this.Controls.Add(this.groupBoxKarton);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PacijentForma";
            this.Text = "Naša Mala Klinika";
            this.Load += new System.EventHandler(this.PacijentForma_Load);
            this.groupBoxKarton.ResumeLayout(false);
            this.groupBoxZakazani.ResumeLayout(false);
            this.groupBoxObavljeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlika)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKarton;
        private System.Windows.Forms.GroupBox groupBoxZakazani;
        private System.Windows.Forms.RichTextBox richTextBoxKarton;
        private System.Windows.Forms.RichTextBox richTextBoxZakazani;
        private System.Windows.Forms.GroupBox groupBoxObavljeni;
        private System.Windows.Forms.RichTextBox richTextBoxObavljeni;
        private System.Windows.Forms.PictureBox pictureBoxSlika;
        private System.Windows.Forms.Label labelPoruka;
        private System.Windows.Forms.Label labelDug;
        private System.Windows.Forms.Label labelImePrezime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulijevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem udesnoToolStripMenuItem;
    }
}
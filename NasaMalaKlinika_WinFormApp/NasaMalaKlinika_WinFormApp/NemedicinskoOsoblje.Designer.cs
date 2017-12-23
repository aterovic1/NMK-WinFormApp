namespace NasaMalaKlinika_WinFormApp
{
    partial class NemedicinskoOsoblje
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
            this.menuStripDoktor = new System.Windows.Forms.MenuStrip();
            this.registracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zauzetostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDoktor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripDoktor
            // 
            this.menuStripDoktor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStripDoktor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registracijaToolStripMenuItem,
            this.zauzetostToolStripMenuItem});
            this.menuStripDoktor.Location = new System.Drawing.Point(0, 0);
            this.menuStripDoktor.Name = "menuStripDoktor";
            this.menuStripDoktor.Size = new System.Drawing.Size(684, 24);
            this.menuStripDoktor.TabIndex = 0;
            this.menuStripDoktor.Text = "menuStrip1";
            // 
            // registracijaToolStripMenuItem
            // 
            this.registracijaToolStripMenuItem.Name = "registracijaToolStripMenuItem";
            this.registracijaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registracijaToolStripMenuItem.Text = "Pregledi";
            // 
            // zauzetostToolStripMenuItem
            // 
            this.zauzetostToolStripMenuItem.Name = "zauzetostToolStripMenuItem";
            this.zauzetostToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.zauzetostToolStripMenuItem.Text = "Statistika";
            // 
            // NemedicinskoOsoblje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.menuStripDoktor);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStripDoktor;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NemedicinskoOsoblje";
            this.Text = "NemedicinskoOsoblje";
            this.menuStripDoktor.ResumeLayout(false);
            this.menuStripDoktor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripDoktor;
        private System.Windows.Forms.ToolStripMenuItem registracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zauzetostToolStripMenuItem;
    }
}
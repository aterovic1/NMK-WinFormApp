﻿namespace NasaMalaKlinika_WinFormApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelRegistracija = new System.Windows.Forms.Label();
            this.buttonVidljivo = new System.Windows.Forms.Button();
            this.linkLabelRegistracija = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGreska = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(433, 192);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(89, 31);
            this.buttonPrijava.TabIndex = 4;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(321, 147);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPassword.Size = new System.Drawing.Size(62, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Lozinka:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(321, 109);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(106, 16);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Korisničko ime:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(433, 147);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(183, 23);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(433, 109);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(183, 23);
            this.textBoxUsername.TabIndex = 0;
            // 
            // labelRegistracija
            // 
            this.labelRegistracija.AutoSize = true;
            this.labelRegistracija.Location = new System.Drawing.Point(324, 250);
            this.labelRegistracija.Name = "labelRegistracija";
            this.labelRegistracija.Size = new System.Drawing.Size(107, 16);
            this.labelRegistracija.TabIndex = 5;
            this.labelRegistracija.Text = "Nemate račun?";
            // 
            // buttonVidljivo
            // 
            this.buttonVidljivo.Image = ((System.Drawing.Image)(resources.GetObject("buttonVidljivo.Image")));
            this.buttonVidljivo.Location = new System.Drawing.Point(622, 147);
            this.buttonVidljivo.Name = "buttonVidljivo";
            this.buttonVidljivo.Size = new System.Drawing.Size(30, 23);
            this.buttonVidljivo.TabIndex = 7;
            this.buttonVidljivo.UseVisualStyleBackColor = true;
            this.buttonVidljivo.Click += new System.EventHandler(this.buttonVidljivo_Click);
            // 
            // linkLabelRegistracija
            // 
            this.linkLabelRegistracija.AutoSize = true;
            this.linkLabelRegistracija.Location = new System.Drawing.Point(430, 250);
            this.linkLabelRegistracija.Name = "linkLabelRegistracija";
            this.linkLabelRegistracija.Size = new System.Drawing.Size(135, 16);
            this.linkLabelRegistracija.TabIndex = 8;
            this.linkLabelRegistracija.TabStop = true;
            this.linkLabelRegistracija.Text = "Registrujte se sada";
            this.linkLabelRegistracija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistracija_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGreska});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGreska
            // 
            this.toolStripStatusLabelGreska.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelGreska.Name = "toolStripStatusLabelGreska";
            this.toolStripStatusLabelGreska.Size = new System.Drawing.Size(0, 17);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.linkLabelRegistracija);
            this.Controls.Add(this.buttonVidljivo);
            this.Controls.Add(this.labelRegistracija);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Naša Mala Klinika";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Label labelRegistracija;
        private System.Windows.Forms.Button buttonVidljivo;
        private System.Windows.Forms.LinkLabel linkLabelRegistracija;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGreska;
    }
}


namespace NasaMalaKlinika_WinFormApp
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
            this.buttonRegistracija = new System.Windows.Forms.Button();
            this.buttonVidljivo = new System.Windows.Forms.Button();
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
            // buttonRegistracija
            // 
            this.buttonRegistracija.Location = new System.Drawing.Point(433, 250);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(183, 29);
            this.buttonRegistracija.TabIndex = 6;
            this.buttonRegistracija.Text = "Registracija";
            this.buttonRegistracija.UseVisualStyleBackColor = true;
            this.buttonRegistracija.Click += new System.EventHandler(this.buttonRegistracija_Click);
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonVidljivo);
            this.Controls.Add(this.buttonRegistracija);
            this.Controls.Add(this.labelRegistracija);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Welcome!";
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
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.Button buttonVidljivo;
    }
}


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
            this.comboBoxAlergija = new System.Windows.Forms.ComboBox();
            this.labelHistorija = new System.Windows.Forms.Label();
            this.comboBoxHistorija = new System.Windows.Forms.ComboBox();
            this.labelStanjePorodica = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelAlergija
            // 
            this.labelAlergija.AutoSize = true;
            this.labelAlergija.Location = new System.Drawing.Point(24, 39);
            this.labelAlergija.Name = "labelAlergija";
            this.labelAlergija.Size = new System.Drawing.Size(154, 14);
            this.labelAlergija.TabIndex = 0;
            this.labelAlergija.Text = "Pacijent je alergičan na";
            // 
            // comboBoxAlergija
            // 
            this.comboBoxAlergija.FormattingEnabled = true;
            this.comboBoxAlergija.Location = new System.Drawing.Point(27, 71);
            this.comboBoxAlergija.Name = "comboBoxAlergija";
            this.comboBoxAlergija.Size = new System.Drawing.Size(151, 22);
            this.comboBoxAlergija.TabIndex = 1;
            // 
            // labelHistorija
            // 
            this.labelHistorija.AutoSize = true;
            this.labelHistorija.Location = new System.Drawing.Point(24, 123);
            this.labelHistorija.Name = "labelHistorija";
            this.labelHistorija.Size = new System.Drawing.Size(92, 14);
            this.labelHistorija.TabIndex = 2;
            this.labelHistorija.Text = "Ranije bolesti";
            // 
            // comboBoxHistorija
            // 
            this.comboBoxHistorija.FormattingEnabled = true;
            this.comboBoxHistorija.Location = new System.Drawing.Point(27, 154);
            this.comboBoxHistorija.Name = "comboBoxHistorija";
            this.comboBoxHistorija.Size = new System.Drawing.Size(151, 22);
            this.comboBoxHistorija.TabIndex = 3;
            // 
            // labelStanjePorodica
            // 
            this.labelStanjePorodica.AutoSize = true;
            this.labelStanjePorodica.Location = new System.Drawing.Point(224, 39);
            this.labelStanjePorodica.Name = "labelStanjePorodica";
            this.labelStanjePorodica.Size = new System.Drawing.Size(230, 14);
            this.labelStanjePorodica.TabIndex = 4;
            this.labelStanjePorodica.Text = "Opće zdravstveno stanje u porodici";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(227, 72);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 18);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(227, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 18);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(227, 119);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(107, 18);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(227, 143);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(107, 18);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(227, 167);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(107, 18);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // KartonUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 246);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelStanjePorodica);
            this.Controls.Add(this.comboBoxHistorija);
            this.Controls.Add(this.labelHistorija);
            this.Controls.Add(this.comboBoxAlergija);
            this.Controls.Add(this.labelAlergija);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KartonUnos";
            this.Text = "Karton pacijenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlergija;
        private System.Windows.Forms.ComboBox comboBoxAlergija;
        private System.Windows.Forms.Label labelHistorija;
        private System.Windows.Forms.ComboBox comboBoxHistorija;
        private System.Windows.Forms.Label labelStanjePorodica;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}
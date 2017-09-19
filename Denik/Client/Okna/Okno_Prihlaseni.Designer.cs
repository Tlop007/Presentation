namespace Client.Okna
{
    partial class Okno_Prihlaseni
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_HlavText = new System.Windows.Forms.Label();
            this.label_InfoText = new System.Windows.Forms.Label();
            this.label_Heslo = new System.Windows.Forms.Label();
            this.textBox_Heslo = new System.Windows.Forms.TextBox();
            this.label_Verze = new System.Windows.Forms.Label();
            this.button_Zrusit = new System.Windows.Forms.Button();
            this.button_Prihlasit = new System.Windows.Forms.Button();
            this.label_Chyba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.denik_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_HlavText
            // 
            this.label_HlavText.AutoSize = true;
            this.label_HlavText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_HlavText.Location = new System.Drawing.Point(99, 42);
            this.label_HlavText.Name = "label_HlavText";
            this.label_HlavText.Size = new System.Drawing.Size(92, 38);
            this.label_HlavText.TabIndex = 1;
            this.label_HlavText.Text = "Deník,\r\n    ahoj Filipe";
            // 
            // label_InfoText
            // 
            this.label_InfoText.AutoSize = true;
            this.label_InfoText.Location = new System.Drawing.Point(12, 87);
            this.label_InfoText.Name = "label_InfoText";
            this.label_InfoText.Size = new System.Drawing.Size(85, 14);
            this.label_InfoText.TabIndex = 2;
            this.label_InfoText.Text = "label_InfoText";
            // 
            // label_Heslo
            // 
            this.label_Heslo.AutoSize = true;
            this.label_Heslo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Heslo.Location = new System.Drawing.Point(28, 115);
            this.label_Heslo.Name = "label_Heslo";
            this.label_Heslo.Size = new System.Drawing.Size(37, 15);
            this.label_Heslo.TabIndex = 3;
            this.label_Heslo.Text = "Heslo";
            // 
            // textBox_Heslo
            // 
            this.textBox_Heslo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Heslo.Location = new System.Drawing.Point(71, 113);
            this.textBox_Heslo.MaxLength = 15;
            this.textBox_Heslo.Name = "textBox_Heslo";
            this.textBox_Heslo.Size = new System.Drawing.Size(242, 22);
            this.textBox_Heslo.TabIndex = 4;
            this.textBox_Heslo.UseSystemPasswordChar = true;
            this.textBox_Heslo.TextChanged += new System.EventHandler(this.textBox_Heslo_TextChanged);
            // 
            // label_Verze
            // 
            this.label_Verze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Verze.AutoSize = true;
            this.label_Verze.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Verze.Location = new System.Drawing.Point(12, 177);
            this.label_Verze.Name = "label_Verze";
            this.label_Verze.Size = new System.Drawing.Size(61, 13);
            this.label_Verze.TabIndex = 5;
            this.label_Verze.Text = "label_Verze";
            // 
            // button_Zrusit
            // 
            this.button_Zrusit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Zrusit.Location = new System.Drawing.Point(213, 151);
            this.button_Zrusit.Name = "button_Zrusit";
            this.button_Zrusit.Size = new System.Drawing.Size(100, 23);
            this.button_Zrusit.TabIndex = 6;
            this.button_Zrusit.Text = "ZRUŠIT";
            this.button_Zrusit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Zrusit.UseVisualStyleBackColor = true;
            this.button_Zrusit.Click += new System.EventHandler(this.button_Zrusit_Click);
            // 
            // button_Prihlasit
            // 
            this.button_Prihlasit.Location = new System.Drawing.Point(107, 151);
            this.button_Prihlasit.Name = "button_Prihlasit";
            this.button_Prihlasit.Size = new System.Drawing.Size(100, 23);
            this.button_Prihlasit.TabIndex = 7;
            this.button_Prihlasit.Text = "PŘIHLÁSIT SE";
            this.button_Prihlasit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Prihlasit.UseVisualStyleBackColor = true;
            this.button_Prihlasit.Click += new System.EventHandler(this.button_Prihlasit_Click);
            // 
            // label_Chyba
            // 
            this.label_Chyba.AutoSize = true;
            this.label_Chyba.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Chyba.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_Chyba.Location = new System.Drawing.Point(248, 97);
            this.label_Chyba.Name = "label_Chyba";
            this.label_Chyba.Size = new System.Drawing.Size(65, 13);
            this.label_Chyba.TabIndex = 8;
            this.label_Chyba.Text = "label_Chyba";
            this.label_Chyba.Visible = false;
            // 
            // Okno_Prihlaseni
            // 
            this.AcceptButton = this.button_Prihlasit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Zrusit;
            this.ClientSize = new System.Drawing.Size(325, 199);
            this.Controls.Add(this.label_Chyba);
            this.Controls.Add(this.button_Prihlasit);
            this.Controls.Add(this.button_Zrusit);
            this.Controls.Add(this.label_Verze);
            this.Controls.Add(this.textBox_Heslo);
            this.Controls.Add(this.label_Heslo);
            this.Controls.Add(this.label_InfoText);
            this.Controls.Add(this.label_HlavText);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Okno_Prihlaseni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno_Prihlaseni";
            this.Shown += new System.EventHandler(this.Okno_Prihlaseni_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_HlavText;
        private System.Windows.Forms.Label label_InfoText;
        private System.Windows.Forms.Label label_Heslo;
        private System.Windows.Forms.TextBox textBox_Heslo;
        private System.Windows.Forms.Label label_Verze;
        private System.Windows.Forms.Button button_Zrusit;
        private System.Windows.Forms.Button button_Prihlasit;
        private System.Windows.Forms.Label label_Chyba;
    }
}
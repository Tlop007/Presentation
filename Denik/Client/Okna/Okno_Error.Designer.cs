namespace Client.Okna
{
    partial class Okno_Error
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
            this.label_HlavText = new System.Windows.Forms.Label();
            this.label_InfoText = new System.Windows.Forms.Label();
            this.panel_Vypis = new System.Windows.Forms.Panel();
            this.richTextBox_Vypis = new System.Windows.Forms.RichTextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_Soubor = new System.Windows.Forms.Label();
            this.pictureBox_error = new System.Windows.Forms.PictureBox();
            this.panel_Vypis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_error)).BeginInit();
            this.SuspendLayout();
            // 
            // label_HlavText
            // 
            this.label_HlavText.AutoSize = true;
            this.label_HlavText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_HlavText.Location = new System.Drawing.Point(99, 42);
            this.label_HlavText.Name = "label_HlavText";
            this.label_HlavText.Size = new System.Drawing.Size(123, 38);
            this.label_HlavText.TabIndex = 1;
            this.label_HlavText.Text = "Oops,\r\n    něco se stalo...";
            // 
            // label_InfoText
            // 
            this.label_InfoText.AutoSize = true;
            this.label_InfoText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoText.Location = new System.Drawing.Point(12, 87);
            this.label_InfoText.Name = "label_InfoText";
            this.label_InfoText.Size = new System.Drawing.Size(83, 15);
            this.label_InfoText.TabIndex = 2;
            this.label_InfoText.Text = "label_InfoText";
            // 
            // panel_Vypis
            // 
            this.panel_Vypis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Vypis.BackColor = System.Drawing.SystemColors.Window;
            this.panel_Vypis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Vypis.Controls.Add(this.richTextBox_Vypis);
            this.panel_Vypis.Location = new System.Drawing.Point(12, 105);
            this.panel_Vypis.Name = "panel_Vypis";
            this.panel_Vypis.Size = new System.Drawing.Size(301, 75);
            this.panel_Vypis.TabIndex = 3;
            // 
            // richTextBox_Vypis
            // 
            this.richTextBox_Vypis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Vypis.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Vypis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Vypis.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_Vypis.Name = "richTextBox_Vypis";
            this.richTextBox_Vypis.ReadOnly = true;
            this.richTextBox_Vypis.Size = new System.Drawing.Size(293, 67);
            this.richTextBox_Vypis.TabIndex = 0;
            this.richTextBox_Vypis.Text = "";
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.Location = new System.Drawing.Point(213, 186);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(100, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "ROZUMÍM...";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_Soubor
            // 
            this.label_Soubor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Soubor.AutoSize = true;
            this.label_Soubor.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Soubor.Location = new System.Drawing.Point(12, 212);
            this.label_Soubor.Name = "label_Soubor";
            this.label_Soubor.Size = new System.Drawing.Size(69, 13);
            this.label_Soubor.TabIndex = 5;
            this.label_Soubor.Text = "label_Soubor";
            // 
            // pictureBox_error
            // 
            this.pictureBox_error.Image = global::Client.Properties.Resources.denik_error;
            this.pictureBox_error.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_error.Name = "pictureBox_error";
            this.pictureBox_error.Size = new System.Drawing.Size(81, 72);
            this.pictureBox_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_error.TabIndex = 0;
            this.pictureBox_error.TabStop = false;
            // 
            // Okno_Error
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 234);
            this.Controls.Add(this.label_Soubor);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.panel_Vypis);
            this.Controls.Add(this.label_InfoText);
            this.Controls.Add(this.label_HlavText);
            this.Controls.Add(this.pictureBox_error);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Okno_Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno_Error";
            this.panel_Vypis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_error;
        private System.Windows.Forms.Label label_HlavText;
        private System.Windows.Forms.Label label_InfoText;
        private System.Windows.Forms.Panel panel_Vypis;
        private System.Windows.Forms.RichTextBox richTextBox_Vypis;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_Soubor;
    }
}
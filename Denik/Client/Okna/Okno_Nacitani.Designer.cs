namespace Client.Okna
{
    partial class Okno_Nacitani
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
            this.pictureBox_Loader = new System.Windows.Forms.PictureBox();
            this.label_InfoText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Loader)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Loader
            // 
            this.pictureBox_Loader.Image = global::Client.Properties.Resources.denik_loader;
            this.pictureBox_Loader.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Loader.Name = "pictureBox_Loader";
            this.pictureBox_Loader.Size = new System.Drawing.Size(42, 42);
            this.pictureBox_Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Loader.TabIndex = 0;
            this.pictureBox_Loader.TabStop = false;
            // 
            // label_InfoText
            // 
            this.label_InfoText.AutoSize = true;
            this.label_InfoText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoText.Location = new System.Drawing.Point(60, 26);
            this.label_InfoText.Name = "label_InfoText";
            this.label_InfoText.Size = new System.Drawing.Size(85, 14);
            this.label_InfoText.TabIndex = 1;
            this.label_InfoText.Text = "label_InfoText";
            // 
            // Okno_Nacitani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 66);
            this.Controls.Add(this.label_InfoText);
            this.Controls.Add(this.pictureBox_Loader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Okno_Nacitani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno_Nacitani";
            this.Shown += new System.EventHandler(this.Okno_Nacitani_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Loader;
        private System.Windows.Forms.Label label_InfoText;
    }
}
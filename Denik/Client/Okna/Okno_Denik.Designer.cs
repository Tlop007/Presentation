namespace Client.Okna
{
    partial class Okno_Denik
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
            this.elementHost_View = new System.Windows.Forms.Integration.ElementHost();
            this.guI_Denik1 = new Client.Okna.GUI.GUI_Denik();
            this.SuspendLayout();
            // 
            // elementHost_View
            // 
            this.elementHost_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost_View.Location = new System.Drawing.Point(0, 0);
            this.elementHost_View.Name = "elementHost_View";
            this.elementHost_View.Size = new System.Drawing.Size(580, 540);
            this.elementHost_View.TabIndex = 0;
            this.elementHost_View.Text = "elementHost_View";
            this.elementHost_View.Child = this.guI_Denik1;
            // 
            // Okno_Denik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 540);
            this.Controls.Add(this.elementHost_View);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Okno_Denik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno_Denik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost_View;
        private GUI.GUI_Denik guI_Denik1;


    }
}
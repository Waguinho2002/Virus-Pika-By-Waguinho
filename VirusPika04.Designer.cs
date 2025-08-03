namespace Virus_Pika__By_Waguinho_
{
    partial class VirusPika04
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
            this.spam = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // spam
            // 
            this.spam.Interval = 50;
            this.spam.Tick += new System.EventHandler(this.spam_Tick);
            // 
            // VirusPika04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VirusPika04";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "VirusPika04";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.VirusPika04_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer spam;
    }
}
namespace Virus_Pika__By_Waguinho_
{
    partial class PikaVirus02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PikaVirus02));
            this.Desligar120 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Desligar120
            // 
            this.Desligar120.Interval = 1000;
            this.Desligar120.Tick += new System.EventHandler(this.Desligar120_Tick);
            // 
            // PikaVirus02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 130);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PikaVirus02";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PikaVirus02";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.PikaVirus02_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Desligar120;
    }
}
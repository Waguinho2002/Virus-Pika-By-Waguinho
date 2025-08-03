namespace Virus_Pika__By_Waguinho_
{
    partial class janelapika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(janelapika));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tempolbl = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.regras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tempolbl
            // 
            this.tempolbl.AutoSize = true;
            this.tempolbl.BackColor = System.Drawing.Color.Blue;
            this.tempolbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempolbl.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempolbl.ForeColor = System.Drawing.Color.Lime;
            this.tempolbl.Location = new System.Drawing.Point(0, -1);
            this.tempolbl.Name = "tempolbl";
            this.tempolbl.Size = new System.Drawing.Size(128, 52);
            this.tempolbl.TabIndex = 1;
            this.tempolbl.Text = "07:00";
            this.tempolbl.Click += new System.EventHandler(this.tempolbl_Click);
            // 
            // tempo
            // 
            this.tempo.Interval = 420000;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // regras
            // 
            this.regras.AutoSize = true;
            this.regras.BackColor = System.Drawing.Color.Blue;
            this.regras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.regras.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regras.ForeColor = System.Drawing.Color.Lime;
            this.regras.Location = new System.Drawing.Point(473, -1);
            this.regras.Name = "regras";
            this.regras.Size = new System.Drawing.Size(184, 52);
            this.regras.TabIndex = 2;
            this.regras.Text = "REGRAS";
            this.regras.Click += new System.EventHandler(this.regras_Click);
            this.regras.MouseEnter += new System.EventHandler(this.regras_MouseEnter);
            // 
            // janelapika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 365);
            this.Controls.Add(this.regras);
            this.Controls.Add(this.tempolbl);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "janelapika";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIKA.exe";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.janelapika_FormClosing);
            this.Load += new System.EventHandler(this.janelapika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tempolbl;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label regras;
    }
}
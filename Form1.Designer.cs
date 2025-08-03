namespace Virus_Pika__By_Waguinho_
{
    partial class Tela_inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_inicial));
            this.texto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check = new System.Windows.Forms.CheckBox();
            this.confirma = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.ClickTroll = new System.Windows.Forms.Button();
            this.Glitch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.Color.Red;
            this.texto.Location = new System.Drawing.Point(6, 80);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(548, 425);
            this.texto.TabIndex = 1;
            this.texto.Text = resources.GetString("texto.Text");
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(12, 475);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(325, 19);
            this.check.TabIndex = 3;
            this.check.Text = "Concordo que irei ferrar meu pc com o Virus PIka.";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // confirma
            // 
            this.confirma.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirma.Location = new System.Drawing.Point(93, 500);
            this.confirma.Name = "confirma";
            this.confirma.Size = new System.Drawing.Size(148, 28);
            this.confirma.TabIndex = 4;
            this.confirma.Text = "START";
            this.confirma.UseVisualStyleBackColor = true;
            this.confirma.Visible = false;
            this.confirma.Click += new System.EventHandler(this.confirma_Click);
            this.confirma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickStartEfeito);
            this.confirma.MouseEnter += new System.EventHandler(this.confirma_MouseEnter);
            this.confirma.MouseLeave += new System.EventHandler(this.confirma_MouseLeave);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(311, 500);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(148, 28);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancel";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ClickTroll
            // 
            this.ClickTroll.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickTroll.Location = new System.Drawing.Point(356, 306);
            this.ClickTroll.Name = "ClickTroll";
            this.ClickTroll.Size = new System.Drawing.Size(188, 82);
            this.ClickTroll.TabIndex = 6;
            this.ClickTroll.Text = "NAO CLIQUE AQUI";
            this.ClickTroll.UseVisualStyleBackColor = true;
            this.ClickTroll.Click += new System.EventHandler(this.ClickTroll_Click);
            // 
            // Glitch
            // 
            this.Glitch.AutoSize = true;
            this.Glitch.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Glitch.ForeColor = System.Drawing.Color.Red;
            this.Glitch.Location = new System.Drawing.Point(4, 49);
            this.Glitch.Name = "Glitch";
            this.Glitch.Size = new System.Drawing.Size(989, 364);
            this.Glitch.TabIndex = 7;
            this.Glitch.Text = resources.GetString("Glitch.Text");
            this.Glitch.Visible = false;
            // 
            // Tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(556, 540);
            this.Controls.Add(this.ClickTroll);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.confirma);
            this.Controls.Add(this.check);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.Glitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(556, 540);
            this.Name = "Tela_inicial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pika.exe";
            this.Load += new System.EventHandler(this.Tela_inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Button confirma;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button ClickTroll;
        private System.Windows.Forms.Label Glitch;
    }
}


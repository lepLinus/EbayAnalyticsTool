using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Win32;
using System.IO.Compression;
using System.IO;

namespace EbayPreisBot
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            WebClient webclient = new WebClient();
            string Versionnum = Application.ProductVersion;
            Versionnum = Versionnum.Replace(".", null);
            try
            {
                if (Convert.ToInt32(webclient.DownloadString("https://www.getyourgame.de/Version")) >= Convert.ToInt32(Versionnum) && webclient.DownloadString("https://www.getyourgame.de").Contains("Update.zip"))
                {
                    if (MessageBox.Show("Newer Version found online, would you like to download it?", "eBay-Scouter Updater", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        webclient.DownloadFile("https://www.getyourgame.de/Update.zip", "Update.zip");
                        if (System.IO.File.Exists(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/Update.zip"))
                        {
                            System.IO.File.Delete(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/Update.zip");
                        }
                        System.IO.File.Move(Application.StartupPath + "/Update.zip", Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/Update.zip");

                        System.IO.DirectoryInfo di = new DirectoryInfo(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/ESC-Update");

                        if (di.Exists)
                        {
                            foreach (FileInfo file in di.GetFiles())
                            {
                                file.Delete();
                            }
                            foreach (DirectoryInfo dir in di.GetDirectories())
                            {
                                dir.Delete(true);
                            }
                        }
                        else
                        {
                            System.IO.Directory.CreateDirectory(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/ESC-Update");
                        }

                        ZipFile.ExtractToDirectory(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/Update.zip", Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/ESC-Update");
                        Process.Start(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/ESC-Update");
                        if (System.IO.File.Exists(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/Update.zip"))
                        {
                            System.IO.File.Delete(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "/Update.zip");
                        }

                        Application.Exit();
                    }
                    else
                    {
                        Application.Run(new Form1(0,""));
                        return;
                    }
                }
                else
                {
                    Application.Run(new Form1(0,""));
                    return;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Connection timed out. No connetion to Web", "eBay-Scouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new Form1(0,""));
        }
    }
}

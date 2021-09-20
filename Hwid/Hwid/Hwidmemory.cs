using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using DynamicFr;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Management;

namespace Hwid
{
    class Program
    {
        public static object Clipboard { get; private set; }

        static void Main(string[] args)
        {
            MsgER import = new MsgER();

            try
            {
                MsgER.VikiPOPUP();
                Console.Title = " V1.0 | Hwid checker by viki#0001 | https://discord.gg/DqTzMeC | https://github.com/Viki965 ";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Please wait...");
                Console.ResetColor();
                Thread.Sleep(500);
                string Ucheck = "v1.0";
                string a;
                a = new WebClient() { Proxy = null }.DownloadString("https://pastebin.com/raw/PcwhHxiP");

                bool flag = a == $"{Ucheck}";
                if (flag)
                {
                    string identity = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Your current hwid is");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($" >> ");
                    Console.ResetColor();
                    Console.Write($"{identity}");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else
                {

                    MsgER.ERROR();
                    Console.WriteLine("Project either disabled or a new verison is out!");
                    Console.WriteLine("Contact viki#0001 or https://discord.gg/DqTzMeC");
                    Console.ReadKey();
                    Console.ResetColor();
                }
            }
            catch (Exception)
            {
                MsgER.ERROR();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong!!");
                Console.ResetColor();
                Thread.Sleep(2500);
            }
            
        }
    }
}

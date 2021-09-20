using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwid
{
    class MsgER
    {
        public static void ERROR()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("███████╗██████╗░██████╗░░█████╗░██████╗░  ░░██╗██╗░█████╗░░░██╗██╗");
            Console.WriteLine("██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ░██╔╝██║██╔══██╗░██╔╝██║");
            Console.WriteLine("█████╗░░██████╔╝██████╔╝██║░░██║██████╔╝  ██╔╝░██║██║░░██║██╔╝░██║");
            Console.WriteLine("██╔══╝░░██╔══██╗██╔══██╗██║░░██║██╔══██╗  ███████║██║░░██║███████║");
            Console.WriteLine("███████╗██║░░██║██║░░██║╚█████╔╝██║░░██║  ╚════██║╚█████╔╝╚════██║");
            Console.WriteLine("╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝  ░░░░░╚═╝░╚════╝░░░░░░╚═╝");
        }

        public static void VikiPOPUP()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("██╗░░░██╗██╗██╗░░██╗██╗░░░██╗░██╗░░█████╗░░█████╗░░█████╗░░░███╗░░");
            Console.WriteLine("██║░░░██║██║██║░██╔╝██║██████████╗██╔══██╗██╔══██╗██╔══██╗░████║░░");
            Console.WriteLine("╚██╗░██╔╝██║█████═╝░██║╚═██╔═██╔═╝██║░░██║██║░░██║██║░░██║██╔██║░░");
            Console.WriteLine("░╚████╔╝░██║██╔═██╗░██║██████████╗██║░░██║██║░░██║██║░░██║╚═╝██║░░");
            Console.WriteLine("░░╚██╔╝░░██║██║░╚██╗██║╚██╔═██╔══╝╚█████╔╝╚█████╔╝╚█████╔╝███████╗");
            Console.WriteLine("░░░╚═╝░░░╚═╝╚═╝░░╚═╝╚═╝░╚═╝░╚═╝░░░░╚════╝░░╚════╝░░╚════╝░╚══════╝");
            Console.ResetColor();
        }
    }
}

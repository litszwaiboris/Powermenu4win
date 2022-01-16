using System;
namespace Powermenu4win
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select an option to proceed\n");
            Console.WriteLine("a. Shutdown\n");
            Console.WriteLine("b. Reboot\n");
            Console.WriteLine("c. Cancel");
            string input = Console.ReadLine();
            if (input == "a")
            {
                string cmdexec = "/c shutdown -s -t 0";
                System.Diagnostics.Process.Start("cmd.exe", cmdexec);
            }
            if (input == "b")
            {
                string cmdexec = "/c shutdown -r -t 0";
                System.Diagnostics.Process.Start("cmd.exe", cmdexec);
            }
            if (input == "c")
            {
                Environment.Exit(0);
            }
        }
    }
}
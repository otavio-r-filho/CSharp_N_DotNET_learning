using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            string[] arguments = Environment.GetCommandLineArgs();

            Console.WriteLine("*** My First C# App ***");

            Console.WriteLine("Checking the number of parameters...");
            Console.WriteLine("Number of parameters received is: " + arguments.Length);


            foreach(string arg in arguments)
            {
                Console.WriteLine(arg);
            }

            Console.WriteLine("Hello World");

            ShowEnvironmentDetails();

            Console.WriteLine("Press any key to continue...");
    
            //Wait for Enter key to be pressed before shutting down
            Console.ReadLine();

            return 0;
        }

        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine(" Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
            Console.WriteLine("User name: {0}", Environment.UserName);
            Console.WriteLine("Ticks: {0}", Environment.TickCount);
            Console.WriteLine("Process allocated memory: {0}", Environment.WorkingSet);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Basic Console I/O ****");
            GetUserData();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
           
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private static void GetUserData()
        {
            ConsoleColor prevColor = Console.ForegroundColor;

            //Get name and age
            Console.Write("Please enter your name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string userName = Console.ReadLine();

            Console.ForegroundColor = prevColor;
            Console.Write("Please enter your age: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string userAge = Console.ReadLine();

            //Change echo color
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Echo to the console
            Console.WriteLine("Hello {0}! You are {1} years old!", userName, userAge);       
        }
    }
}

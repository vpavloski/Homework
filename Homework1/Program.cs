using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic light...");
            Console.WriteLine("");
            //Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Red light - Stop!");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Yellow light - Prepare!");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Green light  - GO!");
            Console.ReadLine();
        }
    }
}

/*
 * Program that prints greeting to the console.
 * Template: C# Console App .NET Framework
 * 
 * M Lentner 2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classic_greetings
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello, world!");

            // wait for user input to close the window
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

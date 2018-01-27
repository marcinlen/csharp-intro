/*
 * Presents data types of C# language.
 * Template: C# Console App .NET Core
 * 
 * Marcin Lentner Jan 2018
 */

using System;

namespace data_types
{
    class Program
    {
        static void Main()
        {
            int int_standard = 3;
            System.Int32 int_net = 3;

            Console.WriteLine("Standard integer type = {0}, .NET integer type = {1}", int_standard, int_net);

            // wait for user input to close the window
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

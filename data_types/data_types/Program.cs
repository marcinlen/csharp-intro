/*
 * Presents common 'value' (primitives, built-in, simple) types of C# language.
 * Template: C# Console App .NET Core
 * 
 * Variables that are based on value types directly contain values. 
 * Assigning one value type variable to another copies the contained value. 
 * This differs from the assignment of reference type variables, 
 * which copies a reference to the object but not the object itself.
 * 
 * All of the built-in types, those integral to the C# language, 
 * are aliases of the .NET Framework System types. 
 * For example, int is an alias of System.Int32.
 * 
 * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types
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
            // integer types
            int simple_int = 3; // built-in type, simple type, primitive type
            System.Int32 framework_int = 3; // .NET Framework type

            // floats (to initialize float use suffix 'f' or 'F')
            float simple_float = 3.14f;
            System.Single framework_float = 3.14F;

            // double
            double simple_double = 12.34;
            System.Double framework_double = 12.34;



            // write to console
            Console.WriteLine("Type: {0}, Value: {1}", simple_int.GetType(), simple_int);
            Console.WriteLine("Type: {0}, Value: {1}", framework_int.GetType(), framework_int);
            Console.WriteLine("Type: {0}, Value: {1}", simple_float.GetType(), simple_float);
            Console.WriteLine("Type: {0}, Value: {1}", framework_float.GetType(), framework_float);
            Console.WriteLine("Type: {0}, Value: {1}", simple_double.GetType(), simple_double);
            Console.WriteLine("Type: {0}, Value: {1}", framework_double.GetType(), framework_double);

            // wait for user input to close the window
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

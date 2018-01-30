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
            /*
             * prefix s - simple type, primitive type, built in type, value type
             * prefix s - .NET Framework type
             */

            // signed 8 bit integer
            sbyte sByte = -128;
            System.SByte fByte = 127;

            // unsigned 8 bit integer
            byte sUnByte = 0;
            System.Byte fUnByte = 255;

            // signed integer types (32 bit precision)
            int sInt = -2147483648; // built-in type, simple type, primitive type
            System.Int32 fInt = 2_147_483_647; // .NET Framework type

            // long (64 bit precision integer)
            long sLong = -9_223_372_036_854_775_808;
            System.Int64 fLong = 0x7FFFFFFFFFFFFFFF;

            // floats (to initialize float use suffix 'f' or 'F') (32 bit precision)
            float sFloat = System.Single.MinValue;
            System.Single fFloat = System.Single.MaxValue;

            // double (64 bit precision)
            double sDouble = System.Double.MinValue;
            System.Double fDouble = System.Double.MaxValue;



            // write to console
            Console.WriteLine("Type: {0}, Value: {1}", sByte.GetType(), sByte);
            Console.WriteLine("Type: {0}, Value: {1}", fByte.GetType(), fByte);
            Console.WriteLine("Type: {0}, Value: {1}", sUnByte.GetType(), sUnByte);
            Console.WriteLine("Type: {0}, Value: {1}", fUnByte.GetType(), fUnByte);
            Console.WriteLine("Type: {0}, Value: {1}", sInt.GetType(), sInt);
            Console.WriteLine("Type: {0}, Value: {1}", fInt.GetType(), fInt);
            Console.WriteLine("Type: {0}, Value: {1}", sLong.GetType(), sLong);
            Console.WriteLine("Type: {0}, Value: {1}", fLong.GetType(), fLong);
            Console.WriteLine("Type: {0}, Value: {1}", sFloat.GetType(), sFloat);
            Console.WriteLine("Type: {0}, Value: {1}", fFloat.GetType(), fFloat);
            Console.WriteLine("Type: {0}, Value: {1}", sDouble.GetType(), sDouble);
            Console.WriteLine("Type: {0}, Value: {1}", fDouble.GetType(), fDouble);

            // wait for user input to close the window
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

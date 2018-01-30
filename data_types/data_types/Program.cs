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
 * Marcin Lentner 01.2018
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
             * prefix f - .NET Framework type
             * 
             * Numeric Types
             */

            // signed 8 bit integer
            sbyte sByte = -128;
            System.SByte fByte = 127;

            // unsigned 8 bit integer
            byte sUnByte = 0;
            System.Byte fUnByte = 255;

            // signed 16 bit integer
            short sShort = -32768;
            System.Int16 fShort = 32767;

            // unsigned 16 bit integer
            ushort sUnShort = 0;
            System.UInt16 fUnShort = 65535;

            // signed 32 bit integer
            int sInt = -2147483648; 
            System.Int32 fInt = 2_147_483_647;

            // unsigned 32 bit integer
            uint sUnInt = 0;
            System.UInt32 fUnInt = 4_294_967_295;

            // signed 64 bit integer
            long sLong = -9_223_372_036_854_775_808;
            System.Int64 fLong = 0x7FFFFFFFFFFFFFFF;

            // unsigned 64 bit integer
            ulong sUnLong = 0;
            System.UInt64 fUnLong = System.UInt64.MaxValue;

            // float 32 bit floating-point value (to initialize float use suffix 'f' or 'F') 
            float sFloat = -3.5F;
            System.Single fFloat = 3.5f;

            // double 64 bit floating-point value
            double sDouble = System.Double.MinValue;
            System.Double fDouble = System.Double.MaxValue;

            // decimal 128 bit floating-point value (financial calculations)(use suffix m for real numbers)
            decimal sDecimal = 300.5m;
            System.Decimal fDecimal = 300;

            // character data type
            char sChar = 'a';
            System.Char fChar = 'z';

            // boolean type
            bool trueValue = true;
            bool falseValue = false;    // default value for bool type

            // write to console
            Console.WriteLine("Type: {0}, Value: {1}", sByte.GetType(), sByte);
            Console.WriteLine("Type: {0}, Value: {1}", fByte.GetType(), fByte);
            Console.WriteLine("Type: {0}, Value: {1}", sUnByte.GetType(), sUnByte);
            Console.WriteLine("Type: {0}, Value: {1}", fUnByte.GetType(), fUnByte);
            Console.WriteLine("Type: {0}, Value: {1}", sShort.GetType(), sShort);
            Console.WriteLine("Type: {0}, Value: {1}", fShort.GetType(), fShort);
            Console.WriteLine("Type: {0}, Value: {1}", sUnShort.GetType(), sUnShort);
            Console.WriteLine("Type: {0}, Value: {1}", fUnShort.GetType(), fUnShort);
            Console.WriteLine("Type: {0}, Value: {1}", sInt.GetType(), sInt);
            Console.WriteLine("Type: {0}, Value: {1}", fInt.GetType(), fInt);
            Console.WriteLine("Type: {0}, Value: {1}", sUnInt.GetType(), sUnInt);
            Console.WriteLine("Type: {0}, Value: {1}", fUnInt.GetType(), fUnInt);
            Console.WriteLine("Type: {0}, Value: {1}", sLong.GetType(), sLong);
            Console.WriteLine("Type: {0}, Value: {1}", fLong.GetType(), fLong);
            Console.WriteLine("Type: {0}, Value: {1}", sUnLong.GetType(), sUnLong);
            Console.WriteLine("Type: {0}, Value: {1}", fUnLong.GetType(), fUnLong);
            Console.WriteLine("Type: {0}, Value: {1}", sFloat.GetType(), sFloat);
            Console.WriteLine("Type: {0}, Value: {1}", fFloat.GetType(), fFloat);
            Console.WriteLine("Type: {0}, Value: {1}", sDouble.GetType(), sDouble);
            Console.WriteLine("Type: {0}, Value: {1}", fDouble.GetType(), fDouble);
            Console.WriteLine("Type: {0}, Value: {1}", sDecimal.GetType(), sDecimal);
            Console.WriteLine("Type: {0}, Value: {1}", fDecimal.GetType(), fDecimal);
            Console.WriteLine("Type: {0}, Value: {1}", sChar.GetType(), sChar);
            Console.WriteLine("Type: {0}, Value: {1}", fChar.GetType(), fChar);
            Console.WriteLine("Type: {0}, Value: {1}", trueValue.GetType(), trueValue);
            Console.WriteLine("Type: {0}, Value: {1}", falseValue.GetType(), falseValue);

            // wait for user input to close the window
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

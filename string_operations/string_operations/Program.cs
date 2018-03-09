using System;

namespace string_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Leeds";
            String country = "United Kingdom";
            string countryCode = "uk";

            // call methods on objects
            countryCode = countryCode.ToUpper();

            // string formatting
            Console.WriteLine("Welcome to {0}, {1}.", city, country);
            Console.WriteLine("Welcome to {0}.", countryCode);

            Console.ReadKey();
        }
    }
}

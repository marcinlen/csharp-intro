/*
 * String facilities in C#
 * 
 * Marcin Lentner 2018
 */

using System;

namespace string_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // different ways of creating string variable
            var city = "Leeds";
            String country = "United Kingdom";
            string countryCode = "   gb ";

            // call methods on string instance
            countryCode = countryCode.ToUpper();
            countryCode = countryCode.Trim();

            // string formatting
            Console.WriteLine("Welcome to {0}, {1} ({2}).", city, country, countryCode);

            /*
             * working with substrings
             */
            string ElonMuskQoutes = "Persistence is very important. You should not give up unless you are forced to give up. The first step is to establish that something is possible; then probability will occur.";

            int nextQuote = ElonMuskQoutes.IndexOf("The first step");
            var ElonA = ElonMuskQoutes.Substring(nextQuote);

            Console.WriteLine(ElonA);


            Console.ReadKey();
        }
    }
}

/*
 * Budget
 * ITSE 1430
 * Semester 2021
 * Orlando Valdez
 */

using System;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Budget");
            Console.WriteLine("ITSE 1430");
            Console.WriteLine("Semester 2021");
            Console.WriteLine("Orlando Valdez");

            Console.WriteLine("\nAccount Name: ");
            string accountName = Console.ReadLine();

            while (String.IsNullOrEmpty(accountName))
            {
                Console.WriteLine("Value is required");
                accountName = Console.ReadLine();
            }
            Console.WriteLine("Valid Account Name.\n");

            Console.WriteLine("Account Number: ");

        }
    }
}

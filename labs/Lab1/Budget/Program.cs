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
            BasicProgramInfo();
            PromptAccountInfo();

            
        }

        static string accountName;
        static string accountNumber;
        static string startingBalance;

        private static void PromptAccountInfo ()
        {
            Console.Write("Enter Account Name:  ");
            accountName = Console.ReadLine();

            Console.Write("Enter Account Number:    ");
            accountNumber = Console.ReadLine();

            Console.Write("Enter Starting Balance:  ");
            startingBalance = Console.ReadLine();            
        }

        private static void BasicProgramInfo ()
        {
            Console.WriteLine("Budget");
            Console.WriteLine("ITSE 1430");
            Console.WriteLine("Semester 2021");
            Console.WriteLine("Orlando Valdez");
        }

        private static void DisplayError ( string message)
        {
            Console.WriteLine(message);
        }
    }
}

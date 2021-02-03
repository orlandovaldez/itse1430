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
        static decimal startingBalance;

        private static void PromptAccountInfo ()
        {
            Console.Write("Enter Account Name:  ");
            accountName = AccountNameCheck();

            Console.Write("Enter Account Number:    ");
            accountNumber = Console.ReadLine();

            Console.Write("Enter Starting Balance:  ");
            startingBalance = BalanceCheck(0);            
        }

        private static string AccountNameCheck ()
        {
            accountName = Console.ReadLine();
            while (String.IsNullOrEmpty(accountName))
            {
                Console.WriteLine("Account Name Must Not Be Empty, Enter Valid Name");
                accountName = Console.ReadLine();
                
            }return accountName;
        }

        static decimal BalanceCheck(decimal minimumBalance )
        {
            do
            {
                //Check to see if the starting balance of account is greater than zero 
                string startingBalance = Console.ReadLine();

                if (Decimal.TryParse(startingBalance, out decimal result))
                {
                    if (result >= minimumBalance)
                        return result;
                    else
                        DisplayError("Balance Must Be Greater Than 0");
                } else
                    DisplayError("Value Must Be Numeric.");

            } while (true);
        }

        static void CheckDigit ()
        {
            string input = Console.ReadLine();
        }

        private static void BasicProgramInfo ()
        {
            //Display user header at the beginning of the program
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

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

            bool done = false;
            do
            {
                AccountInfo();
                char mainMenuOption = DisplayMainMenu();

                switch(mainMenuOption)
                {
                    case 'Q': done = true; break;

                    default: DisplayError("Invalid Selection, Try Again"); break;
                }
            } while (!done);
            
        }

        private static bool QuitProgram ( bool v )
        {
            do
            {
                Console.WriteLine("Are You Sure You Want To Exit? Y/N: ");
                string input = Console.ReadLine();

                if (input == "Y" || input == "y")
                    return true;
                else if (input == "N" || input == "n")
                    return false;
                else
                    DisplayError("Invalid Input, Select Y/N ");
                
            } while (true);
        }

        private static char DisplayMainMenu ()
        {
            
            do
            {
                Console.WriteLine("A) Deposit");
                Console.WriteLine("B) Withdraw");
                Console.WriteLine("Q) Quit");

                string menuInput = Console.ReadLine();

                switch(menuInput)
                {
                    case "A":
                    case "a": return 'A';

                    case "B":
                    case "b": return 'B';

                    case "Q":
                    case "q": return 'Q';
                };

                DisplayError("Invalid Selection, Try Again");
            } while (true);
        }

        static string accountName;
        static string accountNumber;
        static decimal accountBalance;

        private static void AccountInfo()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine($"Account Name: {accountName}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Balance: ${accountBalance}");
        }
       
        private static void PromptAccountInfo ()
        {
            Console.Write("Enter Account Name:   ");
            accountName = AccountNameCheck();

            Console.Write("Enter Account Number: ");
            accountNumber = Console.ReadLine();
            //TODO: AccountNumberValid();
            //      -Must consist of only digits (0-9).
            //      -Must be exactly 12 characters long.
            //      -May not start or end with a zero.  

            Console.Write("Enter Starting Balance:  ");
            accountBalance = BalanceCheck(1);            
        }

        private static string AccountNumberValid ()
        {
            do
            {
                string input = Console.ReadLine();
                for (int index = 0; index < input.Length; ++index)
                {
                    if (!Char.IsDigit(input, index)) ;
                    
                }
                DisplayError("Number must consist of only digits");




            } while (true);
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

        private static decimal BalanceCheck(decimal minimumBalance )
        {
            do
            {
                //Check to see if the starting balance of account is greater than zero 
                string accountBalance = Console.ReadLine();

                if (Decimal.TryParse(accountBalance, out decimal result))
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

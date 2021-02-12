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
        static void Main ( string[] args )
        {
            BasicProgramInfo();
            PromptAccountInfo();

            bool done = false;
            do
            {
                AccountInfo();
                char mainMenuOption = DisplayMainMenu();

                switch (mainMenuOption)
                {
                    case 'A':
                    Deposit(0); DepositDescribe(); Console.WriteLine("Balance Has Been Updated.");
                    break;
                    case 'B':
                    Withdraw(); Console.WriteLine("Balance Has Been Updated.");
                    break;
                    case 'Q':
                    break;

                    default: DisplayError("Invalid Selection, Try Again"); break;
                }
            } while (!done);

        }

        private static decimal Withdraw ()
        {
            do
            {
                // Asks User for withdrawl amount and adjusts balance accordingly.
                Console.Write("Enter Withdrawl Amount: $ "); 
                string withdrawlAmount = Console.ReadLine();

                if (Decimal.TryParse(withdrawlAmount, out decimal result))
                {
                    if (minimumWithdraw <= accountBalance)
                        return accountBalance = accountBalance - result;
                    else if (withdrawlAmount ==  "0")
                        DisplayMainMenu();
                    else
                        DisplayError("Error, Withdrawl amount greater than balance.");                        
                } else
                    DisplayError("Value Must Be Numeric.");
            } while (true);
        }

        private static string DepositDescribe ()
        {
            Console.Write("Enter Deposit Description: ");

            depositDescribe = Console.ReadLine();
            while (String.IsNullOrEmpty(depositDescribe))
            {
                Console.WriteLine("Descpription Required");
                depositDescribe = Console.ReadLine();
            }
            return depositDescribe;
        }

        private static decimal Deposit ( decimal minimumDeposit )
        {
            do
            {
                // Asks User for thier deposit amount and adds to the account accordingly.
                Console.Write("Enter Deposit Amount: $ ");
                string depositAmount = Console.ReadLine();

                if (Decimal.TryParse(depositAmount, out decimal result))
                {
                    if (result >= minimumDeposit)
                        return accountBalance = accountBalance + result;
                    else if (depositAmount == "0")
                        DisplayMainMenu();
                    else
                        DisplayError("Deposit Must Be Greater Than 0");
                } else
                    DisplayError("Value Must Be Numeric.");
            } while (true);
            //TODO
            //Provide info for deposit 
            // Amount (As a positive number)
            // Description (The Description of the transaction)

            //Extra: Category, Check Number, Date(MM/dd/yyyy)
        }

        static string accountName;
        static string accountNumber;
        static decimal accountBalance;
        static decimal depositAmount;
        static string depositDescribe;
        static decimal minimumWithdraw;

        static bool QuitProgram ()
        {
            Console.WriteLine("Are You Sure You Want To Exit? Y/N: ");
            string input = Console.ReadLine();
            do
            {

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

                switch (menuInput)
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


        private static void AccountInfo ()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine($"Account Name: {accountName}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Balance: {accountBalance:C}");
        }

        private static void PromptAccountInfo ()
        {
            Console.Write("Enter Account Name:   ");
            accountName = AccountNameCheck();

            Console.Write("Enter Account Number: ");
            accountNumber = AccountNumberValid();
            //TODO: AccountNumberValid();
            //      -Must consist of only digits (0-9).
            //      -Must be exactly 12 characters long.
            //      -May not start or end with a zero.  

            Console.Write("Enter Starting Balance:  ");
            accountBalance = BalanceCheck(1);
        }

        private static string AccountNumberValid ()
        {
            bool validNumber = false;
            string input = Console.ReadLine();

            
                for (int index = 0; index < input.Length; ++index)
                {
                    if (!Char.IsDigit(input, index))
                    {

                        DisplayError("Invalid Account Number");
                        validNumber = false;
                    } else
                        Console.WriteLine("Number Accepted");
                        validNumber = true;

                    //break;
                }
                return input;


           

        }

        private static string AccountNameCheck ()
        {
            accountName = Console.ReadLine();
            while (String.IsNullOrEmpty(accountName))
            {
                Console.WriteLine("Account Name Must Not Be Empty, Enter Valid Name");
                accountName = Console.ReadLine();

            }
            return accountName;
        }

        private static decimal BalanceCheck ( decimal minimumBalance )
        {
            do
            {
                //Check to see if the starting balance of account is greater than zero 
                string accountBalance = Console.ReadLine();

                if (Decimal.TryParse(accountBalance, out decimal result))
                {
                    if (result >= minimumBalance)
                    {
                        Console.WriteLine("Valid Balance Accepted.");
                        return result;
                    } else
                        DisplayError("Balance Must Be Greater Than 0");
                } else
                    DisplayError("Value Must Be Numeric Or Not Empty.");

            } while (true);
        }


        private static void BasicProgramInfo ()
        {
            //Display user header at the beginning of the program
            Console.WriteLine("Budget");
            Console.WriteLine("ITSE 1430");
            Console.WriteLine("Semester 2021");
            Console.WriteLine("Orlando Valdez");
        }

        private static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }
    }
}

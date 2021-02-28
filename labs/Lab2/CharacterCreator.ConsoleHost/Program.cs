/*
 * CharacterCreator.ConsoleHost
 * ITSE 1430
 * Semester 2021
 * Orlando Valdez
 */

using System;

namespace CharacterCreator.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayProgramInfo();

            bool done = false;
            do
            {
                char mainMenuOption = DisplayMainMenu();

                switch (DisplayMainMenu())
                {
                    case 'A':
                    break;
                    case 'B':
                    break;
                    case 'C':
                    break;
                    case 'Q': done = QuitProgram();
                    break;

                    default: DisplayError("Invalid Selection, Try Again.");
                    break;
                };
            }while (!done);
        }

        static bool QuitProgram ()
        {
            if (ReadBoolean("Are you sure you want to quit (Y/N)? "))
                return true;
            return false;
        }

        private static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

        static char DisplayMainMenu ()
        {
            do
            {
                Console.WriteLine("A) PlaceHolder ");
                Console.WriteLine("B) PlaceHolder ");
                Console.WriteLine("Q) Quit Program ");

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

            } while (true);
        }

        static void DisplayProgramInfo () //Displays Basic Program Information 
        {
            Console.WriteLine("CharacterCreator.ConsoleHost");
            Console.WriteLine("ITSE 1430 Semester 2021");
            Console.WriteLine();
        }

        static bool ReadBoolean ( string message )
        {
            Console.Write(message);

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.Y: return true;
                    case ConsoleKey.N: return false;
                };
            } while (true);
        }
    }
}

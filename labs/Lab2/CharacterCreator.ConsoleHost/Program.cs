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
                    case 'A': AddCharacter();
                    break;
                    case 'B':
                    break;
                    case 'C': ViewCharacter();
                    break;
                    case 'Q': done = QuitProgram();
                    break;

                    default: DisplayError("Invalid Selection, Try Again.");
                    break;
                };
            }while (!done);
        }

        static Character _character;

        static void AddCharacter ()
        {
            Character character = new Character();

            Console.Write("Enter Character Name: ");
            character.name = Console.ReadLine();

            Console.Write("Enter Character Profession: ");
            character.profesion = Console.ReadLine();

            Console.Write("Enter Character Race: ");
            character.race = Console.ReadLine();

            Console.Write("Enter Character Description(if any): ");
            character.biography = Console.ReadLine();

            _character = character;
        }

        static void ViewCharacter ()
        {
            //TODO: Finish up viewing character and attributes
            Console.WriteLine($"{_character.name}");
        }

        static bool QuitProgram ()
        {
            if (ReadBoolean("Are you sure you want to quit (Y/N)? "))
                return true;
            return false;
        }

        private static void DisplayError ( string message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static char DisplayMainMenu ()
        {
            do
            {
                Console.WriteLine("A) Add Character");
                Console.WriteLine("B) Delete Character");
                Console.WriteLine("C) Edit Character");
                Console.WriteLine("D) View Character");
                Console.WriteLine("Q) Quit Program ");

                string menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "A":
                    case "a": return 'A';

                    case "B":
                    case "b": return 'B';

                    case "C":
                    case "c": return 'C';

                    case "D":
                    case "d": return 'D';

                    case "Q":
                    case "q": return 'Q';


                };
                DisplayError("Invalid Selection, Try Again");
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

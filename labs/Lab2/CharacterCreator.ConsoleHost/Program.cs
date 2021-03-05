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

                switch (mainMenuOption)
                {
                    case 'A': AddCharacter();
                    break;
                    case 'D': DeleteCharacter();
                    break;
                    case 'E': EditCharacter();
                    break;
                    case 'V': ViewCharacter();
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
            character.Name = CharacterName();

            Console.WriteLine("Choose Character Profession (Fighter, Hunter, Priest, Rogue, Wizard):  ");
            character.Profession = CharacterProfession();

            Console.WriteLine("Choose Character Race (Dwarf, Elf, Gnome, Half Elf, Human):  ");
            character.Race = CharacterRace();

            Console.WriteLine("Enter Character Description(if any): ");
            character.Biography = Console.ReadLine();

            Console.WriteLine("Enter Character Attributes");


            Console.WriteLine("Strength: ");
            character.Strength = ReadInt32();

            Console.WriteLine("Intelligence: ");
            character.Intelligence = ReadInt32();

            Console.WriteLine("Agility: ");
            character.Agility = ReadInt32();

            Console.WriteLine("Constitution: ");
            character.Constitution = ReadInt32();

            Console.WriteLine("Charisma: ");
            character.Charisma = ReadInt32();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Character Saved Successfully!");
            Console.ResetColor();


            _character = character;
        }

        static string CharacterName ()
        {
            do
            {
                string nameInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(nameInput)) 
                    return nameInput;
                DisplayError("Name Cannot Be Empty, Try Again");
            } while (true);
        }
        static string CharacterProfession ()
        {

            do
            {

                string professionInput = Console.ReadLine();

                switch (professionInput)
                {
                    case "Fighter":
                    case "FIGHTER":
                    case "fighter": return "Fighter";

                    case "Hunter":
                    case "HUNTER":
                    case "hunter": return "Hunter";

                    case "Rogue":
                    case "ROGUE":
                    case "rogue": return "Rogue";

                    case "Priest":
                    case "PRIEST":
                    case "priest": return "Priest";

                    case "Wizard":
                    case "WIZARD":
                    case "wizard": return "Wizard";

                };
                DisplayError("Invalid Profession, Try Again.");
            } while (true);
        }

        static string CharacterRace ()
        {
            do
            {
                string raceInput = Console.ReadLine();

                switch (raceInput)
                {
                    case "Dwarf":
                    case "dwarf": return "Dwarf";

                    case "Elf":
                    case "elf": return "Elf";

                    case "Half Elf":
                    case "HalfElf":
                    case "half elf":
                    case "halfelf":
                    case "half Elf":
                    case "Half elf": return "Half Elf";

                    case "Human":
                    case "human": return "Human";

                    case "Gnome":
                    case "gnome": return "Gnome";
                    
                };
                DisplayError("Invalid Race, Try Again.");
            } while (true);
        }

        static void  DeleteCharacter()
        {
            ViewCharacter();
            //if (ReadBoolean("Are you sure you want to delete character (Y/N)? "))
            //    return true;
            
            //return false;
        }

        static void EditCharacter()
        {
            bool done = false;
            do
            {
                char editOption = DisplayEditMenu();

                switch (editOption)
                {
                    case 'A':
                    Console.Write("Enter Character Name: ");
                    _character.Name = CharacterName();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;
                    case 'B':
                    Console.WriteLine("Choose Character Profession (Fighter, Hunter, Priest, Rogue, Wizard):  ");
                    _character.Profession = CharacterProfession();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;
                    case 'C':
                    Console.WriteLine("Choose Character Race (Dwarf, Elf, Gnome, Half Elf, Human):  ");
                    _character.Race = CharacterRace();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;
                    case 'D':
                    Console.WriteLine("Enter Character Description(if any): ");
                    _character.Biography = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;
                    case 'E':
                    Console.WriteLine("Strength: ");
                    _character.Strength = ReadInt32();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;
                    case 'F':
                    Console.WriteLine("Intelligence: ");
                    _character.Intelligence = ReadInt32();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;
                    case 'G':
                    Console.WriteLine("Agility: ");
                    _character.Agility = ReadInt32();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;
                    case 'H':
                    Console.WriteLine("Constitution: ");
                    _character.Constitution = ReadInt32();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;
                    case 'I':
                    Console.WriteLine("Charisma: ");
                    _character.Charisma = ReadInt32();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Edit Saved Successfully!");
                    Console.ResetColor();
                    break;

                    case 'M':
                    done = true; QuitProgram();
                    break;

                    default: DisplayError("Invalid Selection, Try Again.");
                    break;
                };
            } while (!done);

        }

        static char DisplayEditMenu ()
        {
            ViewCharacter();
            Console.WriteLine("Character Editor");
            Console.WriteLine("".PadLeft(40, '*'));

            Console.WriteLine("A) Edit Name ");
            Console.WriteLine("B) Edit Profession");
            Console.WriteLine("C) Edit Race");
            Console.WriteLine("D) Edit Biography");
            Console.WriteLine("E) Edit Strength");
            Console.WriteLine("F) Edit Intelligence");
            Console.WriteLine("G) Edit Agility");
            Console.WriteLine("H) Edit Constitution");
            Console.WriteLine("I) Edit Charisma\n");

            Console.WriteLine("M) Return To Main Menu");
                    
            do
            {
                string editInput = Console.ReadLine();

                switch (editInput)
                {
                    case "A":
                    case "a": return 'A';

                    case "B":
                    case "b": return 'B';

                    case "C":
                    case "c": return 'C';

                    case "D":
                    case "d": return 'D';

                    case "E":
                    case "e": return 'E';

                    case "F":
                    case "f": return 'F';

                    case "G":
                    case "g": return 'G';

                    case "H":
                    case "h": return 'H';

                    case "I":
                    case "i": return 'I';

                    case "M":
                    case "m": return 'M';
                };
                DisplayError("Invalid Selection, Try Again");
            } while (true);
        }

        static void ViewCharacter ()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("".PadLeft(40, '-'));


            Console.WriteLine($"Character Name: {_character.Name}");
            
            Console.WriteLine($"Character Profession: {_character.Profession}");

            Console.WriteLine($"Character Race: {_character.Race}");

            if (!String.IsNullOrEmpty(_character.Biography))
                Console.WriteLine($"Character Details: {_character.Biography} ");

            Console.WriteLine("Attributes");
            Console.WriteLine($"Strength:     {_character.Strength}");
            Console.WriteLine($"Intelligence: {_character.Intelligence}");
            Console.WriteLine($"Agility:      {_character.Agility}");
            Console.WriteLine($"Constitution: {_character.Constitution}");
            Console.WriteLine($"Charisma:     {_character.Charisma}");

            Console.WriteLine("".PadLeft(40, '-'));

            Console.ResetColor();

        }

        static bool QuitProgram ()
        {
            if (ReadBoolean("Are you sure you want to quit (Y/N)? "))
                return true;
            return false;
        }

        static int ReadInt32 ( int minValue = 0, int maxValue = 100 )
        {
            do
            {
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    input = "";
               
                int result;

                if (Int32.TryParse(input, out result) && result >= minValue && result <= maxValue)
                    return result;

                DisplayError($"Value Must Be Between {minValue} - {maxValue}.");
            } while (true);
        }
        private static void DisplayError ( string message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static char DisplayMainMenu ()
        {
            Console.WriteLine(" ");
            Console.WriteLine("".PadLeft(40, '*'));
            Console.WriteLine("Character Creator");
            Console.WriteLine("".PadLeft(40, '*'));

            Console.WriteLine("A) Add Character");
            Console.WriteLine("D) Delete Character");
            Console.WriteLine("E) Edit Character");
            Console.WriteLine("V) View Character");
            Console.WriteLine("Q) Quit Program ");

            do
            {                
                string menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "A":
                    case "a": return 'A';

                    case "D":
                    case "d": return 'D';

                    case "E":
                    case "e": return 'E';

                    case "V":
                    case "v": return 'V';

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

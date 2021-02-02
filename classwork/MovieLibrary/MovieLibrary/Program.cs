/*
 * ITSE 1430
 * Spring 2021
 * Sample Implementation
 */

using System;

namespace MovieLibrary
{
    class Program
    {
        static void Main() //(string[] args)
        {
            AddMovie();

            DisplayMainMenu();
        }
        // modifiers* T identifier ( [parameters] ) { s* }
        //function declaration - function signature that tells the compiler a function exists 
        // function signature - function declaration + implementation
        private static void DisplayMainMenu ()
        {
            //Display output - equivalent to printf, cout
            //Console.Write();
            Console.WriteLine("Movie Library"); // String literals are enclosed in double quotes
            Console.WriteLine("-------------");

            Console.WriteLine("A) dd Movie");
            Console.WriteLine("Q) uit");

            //Console Input
            string input = Console.ReadLine();      // string Readline();

            //TODO: Validate Input
            //TODO: Return Selected Option

        }

        //Get movie from user
        static void AddMovie ()
        {
            // title, release year, run length (min), description, rating
            Console.Write("Enter a title: ");
            string title = Console.ReadLine();

            Console.Write("Enter an optional description: ");
            string description = Console.ReadLine();

            Console.Write("Enter a release year: ");
            int releaseYear = ReadInt32();

            Console.Write("Enter the run length in minutes: ");
            int runLength = ReadInt32();

            Console.Write("Enter the rating: ");
            string rating = Console.ReadLine();

            Console.Write("Is this a classic (Y/N)? ");
            bool isClassic = ReadBoolean();

        }

        static bool ReadBoolean ()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            //TODO: Handle key values
            
            return true;
        }

        //Reads an integer value
        static int ReadInt32 ()
        {
            //TODO: Handle min value

            //TODO: Keep Prompting until valid value
            string input = Console.ReadLine();

            //TODO: Fix so it doesnt crash if not integer
            //Convert string to int 
            int value = Int32.Parse(input); //atoi

            return value;
        }

        void DemoTypes ()
        {
            //Primitive types - types known by the compiler 

            //integrals - signed
            // byte  | 1 byte  | -128 to 127
            // short | 2 bytes | +-32K
            // int   | 4 bytes | +-2 billion  | default
            // long  | 8 bytes | really large | only for really large values 
            sbyte sbyteValue = 10;  //int literal
            short shortValue = 10;  //int literal
            int hours = 20;
            long starsInGalaxy = 1_000_000_000;
            long anotherLong = 10L; // Long literal

            //integrals - unsigned 
            // byte   | 1 byte  | 0 to 255
            // ushort | 2 bytes | 0 to 64K
            // uint   | 4 bytes | 0 ti 4 billion
            // ulong  | 8 bytes | really large
            byte byteCode = 0xAF;
            ushort shortCode = 0X1045;
            uint hourCode = 0x145678;
            ulong longCode = 0b0010_1010_1111;
            ulong ulongCode = 10UL; // ulong literal

            //floating point 
            // float | 4 bytes | +-E38 | 7-9 precision 123.456789
            // double | 8 bytes | +-E308 | 15-17 precision | default
            // decimal | 80 bytes | currency (money)
            float delta = 4.5F;
            double taxRate = 8.75;
            decimal payRate = 12.50M;   //Decimal literal

            //Textual 
            // char | 2 bytes | Single character
            // string | * | Text
            char letter = 'A';                  //Char literals are single quoted
            string className = "ITSE 1430";     //String literals are double quoted 

            //Miscellaneous
            // bool | 1 bit | true or false 
            bool isPassing = true; //false 
            //int isOk = 1; //Wrong

            //Other ( not primitive types  )
            // DateTime  | Date-time value 
            // TimeSpan | time of day or duration
            // Guid | Unique Value 
            DateTime today;
            TimeSpan duration;
            Guid uniqueId;

        }

        void DemoVariable()
        {
            //variable declaration ::= T id ;
            //  block-style declarations -> put all declarations at top of the function, grouped together
            //  inline-style declaration -> declare variables as needed
            string textInput = "";
            //other code ...
            //textInput = ""; //should always initialize variables as part of declaration 

            //assignment statement ::= id = E ;
            //          id - must be an lvalue ( left value ) 
            //          E - any rvalue (right value) provided it is type compatible 
            //          operator presadence - order in which operators are evaluated 4 + 5 * 10 = 54
            //          operator associativity - which operator evaluated first ( left, right) - right
            //textInput = "Hello";
            
            //All reads of variable must be definitely assigned 
            //  Compiler must be able to verify that all possible code paths to the read ensure that 
            //  variable is first writtten to 
            string textInput2 = textInput;

            //Multiple declarations
            //  variable-declaration ::= T id [ = E ] { , id [ = E ]}* ;

            int x = 10, y = 12;

            //Identifier rules
            //1. Must start with letter or underscore 
            //2. Consist of letters or digits or underscores 
            //3. Must be unique in scoper 
            //4. Cannot be a keyword 

            //Variable name guidlines 
            // nouns, descriptive( e.g. firstName, payRate, hours) - describe data 
            // generally less than 15 characters long 
            // are not single letters (e.g. x, y)
            // no abbreveations or acronyms unless they are well known ( good: ok, bad: nbr, num)
            // USE camel casing (capitalize on word boundriesm lowercase first word - e.g. firstName, payRate, hours)

            //Function Name Guidelines 
            // descriptive verbs ( e.g. Get ... , Display ... , Calculate ... ) 
            // Use Pascal casing 
            // No abbreveations or acronyms unless they are well known ( good: ok, bad: nbr, num)
        }

        //Data to collect - title, genre, release year, actors, runtime, director, rating
        // title, release year, run length (min), description, rating
    }
}

﻿/*
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
            bool done = false;
            do
            {
                char option = DisplayMainMenu();

                if (option == 'A')
                    AddMovie();
                else if (option == 'V')
                    ViewMovie();
                else if (option == 'Q')
                    done = true;
               
                else
                    DisplayError("Unknown command");
            } while (!done);
        }
        // modifiers* T identifier ( [parameters] ) { s* }
        //function declaration - function signature that tells the compiler a function exists 
        // function signature - function declaration + implementation
        private static char DisplayMainMenu ()
        {
            //Display output - equivalent to printf, cout
            //Console.Write();
            Console.WriteLine("Movie Library"); // String literals are enclosed in double quotes
            Console.WriteLine("-------------");

            Console.WriteLine("A) dd Movie");
            Console.WriteLine("V) iew Movie");
            Console.WriteLine("Q) uit");

            //Console Input
            do
            {
                string input = Console.ReadLine();      // string Readline();

                //TODO: Validate Input
                if (input == "A" || input == "a")
                    return 'A';
                else if (input == "Q" || input == "q")
                    return 'Q';
                else if (input == "V" || input == "v")
                    return 'V';

                DisplayError("Invalid Option");
            } while (true);

        }

        //Get movie from user
        static void AddMovie ()
        {
            // title, release year, run length (min), description, rating
            Console.Write("Enter a title: ");
             title = Console.ReadLine();

            Console.Write("Enter an optional description: ");
             description = Console.ReadLine();

            Console.Write("Enter a release year: ");
             releaseYear = ReadInt32(1900);

            Console.Write("Enter the run length in minutes: ");
             runLength = ReadInt32(0);

            Console.Write("Enter the rating: ");
             rating = Console.ReadLine();

            Console.Write("Is this a classic (Y/N)? ");
             isClassic = ReadBoolean();

            ViewMovie();
        }

        static string title;
        static string description;
        static int releaseYear;
        static int runLength;
        static string rating;
        static bool isClassic;

        static void ViewMovie ()
        {
            //TODO: Format
            Console.WriteLine(title);
            Console.WriteLine(description);
            Console.WriteLine(releaseYear);
            Console.WriteLine(runLength);
            Console.WriteLine(rating);
            Console.WriteLine(isClassic);

        }

        // Reads a boolean value from the console
        static bool ReadBoolean ()
        {
            do
            {
                //ConsoleKeyInfo key = Console.ReadKey();
                string input = Console.ReadLine();

                //TODO: Case does not matter
                // input == "Y" || "y" -: Not correct
                if (input == "Y" || input == "y")
                    return true;
                else if (input == "N" || input == "n")
                    return false;

                DisplayError("Please enter either Y or N");
            } while (true);
        }

        //Reads and integer value from the console
        static int ReadInt32 ( )
        {
            return ReadInt32(Int32.MinValue);
        }

        //Reads an integer value
        static int ReadInt32 ( int minimumValue )
        {
            //TODO: Handle min value

            // WHILE statement 
            //  while (Eb) S;
            //    S executes 0 or more times (pretest)
            // DO WHILE statement
            //  do S while (Eb) ;
            //    S executes at least once (posttest)
            // break statment 
            //      Only valid in loop contructs
            //      immedialtely exits the current loop
            // continue statement
            //      only valid in loop constructs
            //      immediately exits the current iteration and checks the loop again

            do
            {
                //TODO: Keep Prompting until valid value
                string input = Console.ReadLine();

                //TODO: Fix so it doesnt crash if not integer
                //Convert string to int 
                //int value = Int32.Parse(input);   //atoi

                // IF statement 
                // if (Eb) S;
                // if (Eb)
                //    St
                // else 
                //    Sf;
                // if (Eb_
                //    St
                // else if (Eb)
                //     Stt;
                // else
                //    Sf;
                //int result;
                //if (Int32.TryParse(input, out result))
                if (Int32.TryParse(input, out int result)) //Inline variable declaration
                {
                    //Make sure it is at least minValue
                    if (result >= minimumValue)
                        return result;
                    else
                        DisplayError("Value must be at least " + minimumValue);
                }else
                    DisplayError("Value must be numeric");
            } while (true);
        }

        private static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

        void DemoExpressions ()
        {
            //Arithmetic (op1 op op2) 
            // op1 and op2 must be exact same type 
            // If they are not then type coecerianm (compiler type casting - always safe )
            //      double + int = double + double = double 
            int result = 4 + 5;
            result = 5 - 45;
            result = 8 * 45;
            result = 8 / 5; //Int divison : 1
            result = 8 % 5; // result: 3    isEven ::= numlber % 2 == 0

            result = 4 + 6 * 5; //4 + (6 * 5) = 34

            //Logical (bool op bool => bool)
            //      Not Same = same x && Y || z (x && Y) || z not X && (Y || Z)
            bool logicalResult = true && true;  //Logical AND
            logicalResult = true || true;       //Logical OR
            logicalResult = !true;              //Logical !

            // Relational (op1 rop op2 => bool)
            bool relationalResult = 10 > 20;
            relationalResult = 10 < 20;
            relationalResult = 10 >= 20;
            relationalResult = 10 <= 20;
            relationalResult = 10 != 20;    //Not equal
            relationalResult = 10 == 20;    //Equality

            // Conditional 
            //    E ? Et : Ef 
            // if (E)
            //    Et
            // else 
            //    Ef
            // Et and Ef must be the exact same type 


            // Misc
            // assignment lvalue = E
            //   right associative : equals the right side first then the left 
            logicalResult = relationalResult = false;

            // Prefix and postfix increment and decrements
            result = 5;
            int postfixinc = result++; //result += 1; original value of result 
            int prefixinc = ++result;   //result += 1; result 
            int postfixdec = result--;
            int prefixdec = --result;

            //Function calls 
            //   Parameter ::= variable inside function definition used to store temporary value
            //   Arguement ::= expression used to assign a value to a parameter 
            //   Kinds of parameter ::= Foo(x)
            //      Input (pass by value) - copies the arguement value into the parameter's memory location, two separate copies 
            //          Foo(12);
            //      Input/Output (pass by reference) - temporarily share the same memory location for two different variables
            //          Foo(ref arg);
            //      Output - Funciton caller provides space but hte function provides the value
            //          Foo(out arg);
            result = ReadInt32();
            result = Int32.Parse("123");
        }

        //Input parameter - T name 
        //Input/Output parameter = ref T name
        //Output parameter - T name 
        void Foo ( int inputParameter, ref double ioParameter, out bool result  )
        {
            result = false;
        }

        void DemoTypes ()
        {
            //Primitive types - types known by the compiler 

            //integrals - signed
            // byte  | 1 byte  | -128 to 127            (SByte.Tryparse/Parse)
            // short | 2 bytes | +-32K                  (Int16.TryParse/Parse)
            // int   | 4 bytes | +-2 billion  | default (Int32.TryParse/Parse)
            // long  | 8 bytes | really large | only for really large values ( Int64.TryParse/Parse
            sbyte sbyteValue = 10;  //int literal
            short shortValue = 10;  //int literal
            int hours = 20;
            long starsInGalaxy = 1_000_000_000;
            long anotherLong = 10L; // Long literal

            //integrals - unsigned 
            // byte   | 1 byte  | 0 to 255              (Byte.TryParse/Parse)
            // ushort | 2 bytes | 0 to 64K              (uShort
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
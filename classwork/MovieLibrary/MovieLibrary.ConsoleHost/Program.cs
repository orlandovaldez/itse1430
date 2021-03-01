/*
 * ITSE 1430
 * Spring 2021
 * Sample Implementation
 */

using System; //Bring into scope all the types defined in the given namespace

//Renamed to match project name
namespace MovieLibrary
{
    namespace ConsoleHost
    { }
}
namespace MovieLibrary.ConsoleHost
{
    class Program   //MovieLibrary.ConsoleHost.Program
    {
        static void Main() //(string[] args)
        {
            //Fully qualified type name: System.Boolean     [namespace].[type]
            // MovieLibrary.ConsoleHost.Boolean ( not found )
            // MovieLibrary.Boolean (not found)
            // System.Boolean (found)
            bool done = false;
            do
            {
                char option = DisplayMainMenu();

                // Switch statement is equivalent to a series of if-else-if with equality checks
                //  switch-statement ::= switch (E) { case-statement* [default-statement] };
                //  case-statment    ::= case E : S ;
                //  default-statement ::= default : S ;
                //
                //  Case Label Rules:
                //      -Must be constant values : literals or simple expressions of constant values 
                //      -Must be unique
                //      -Can be a string
                //  Fallthrough Behavior
                //      -No
                //      -Every case statement must end with either break or return statement
                //      -Allowed if case label has no statement (including semicolon)
                // Styling Rules
                //      - Single statement ( excluding break) no block statement needed
                //      - Multiple statements (excluding break) should use block statement to avoid compiler errors
                //switch(10)
                //{
                //    case 10: S1;S2;S3; break;
                //    case 12:
                //    {
                //        int x; x = 10;
                //        break;
                //    };
                //    case 13: SByte; break;
                //}
                //if (option == 'A')
                //    AddMovie();
                //else if (option == 'V')
                //    ViewMovie();
                //else if (option == 'Q')
                //    done = true;               
                //else
                //    DisplayError("Unknown command");
                switch(option)
                {
                    case 'A': AddMovie(); break;
                    case 'V': ViewMovie(); break;
                    case 'Q': done = true; break;

                    default: DisplayError("Unknown Command"); break;
                }

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
            //Console.WriteLine("-------------");
            Console.WriteLine("".PadLeft(20, '-'));

            Console.WriteLine("A) dd Movie");
            Console.WriteLine("V) iew Movie");
            Console.WriteLine("Q) uit");

            //Console Input
            do
            {
                string input = Console.ReadLine();      // string Readline();

                //Validate Input
                //if (input == "A" || input == "a")
                //    return 'A';
                //else if (input == "Q" || input == "q")
                //    return 'Q';
                //else if (input == "V" || input == "v")
                //    return 'V';
                switch(input)
                {
                    case "A":
                    case "a": return 'A';

                    case "Q":
                    case "q": return 'Q';

                    case "V":
                    case "v": return 'v';

                };

                DisplayError("Invalid Option");
            } while (true);

        }

        //Get movie from user
        static void AddMovie ()
        {
            // new T(); 
            // Movie* movie = new Movie();
            Movie movie = new Movie();
            
            //Member access operator
            //  member-access ::= E . Member

            // title, release year, run length (min), description, rating
            Console.Write("Enter a title: ");
             movie.title = Console.ReadLine();

            Console.Write("Enter an optional description: ");
             movie.description = Console.ReadLine();

            Console.Write("Enter a release year: ");
             movie.releaseYear = ReadInt32(1900);

            Console.Write("Enter the run length in minutes: ");
             movie.runLength = ReadInt32(0);

            Console.Write("Enter the rating: ");
             movie.rating = Console.ReadLine();

            Console.Write("Is this a classic (Y/N)? ");
             movie.isClassic = ReadBoolean();

            //Hiding the field movie
            //this.movie = movie;
            _movie = movie;

            ViewMovie();
        }

        static Movie _movie;

        static void ViewMovie ()
        {
            Console.WriteLine($"{_movie.title}({_movie.releaseYear})");
            if (_movie.runLength >0)
                Console.WriteLine($"Running Time: {_movie.runLength} minutes");
            if (!String.IsNullOrEmpty(_movie.rating))
                Console.WriteLine($"MPAA Rating: {_movie.rating}");
            Console.WriteLine($"Classic? {(_movie.isClassic ? 'Y' : 'N')}");

            if (!String.IsNullOrEmpty(_movie.description))
                Console.WriteLine(_movie.description);
        }

        // Reads a boolean value from the console
        static bool ReadBoolean ()
        {
            do
            {
                //ConsoleKeyInfo key = Console.ReadKey();
                string input = Console.ReadLine();

                //// Case does not matter
                //// input == "Y" || "y" -: Not correct
                ////Comparison 1
                //if (input == "Y" || input == "y")
                //    return true;
                //else if (input == "N" || input == "n")
                //    return false;

                //Should use switch but will play around with comparison
                //Not really recommended
                //Comparison 2
                //if (input.ToUpper() == "Y")
                //    return true;
                //else if (input.ToLower() == "n")
                //    return false;

                //Comparison 3 
                if (String.Compare(input, "Y", true) == 0)
                    return true;
                else if (String.Compare(input, "N", true) == 0)
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
            //  Handle Minimum Value

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
                // Type Inferencing 

                //Keep Prompting until valid value
                // ? value = 43.5 + 56;
                //string input = Console.ReadLine();
                var input = Console.ReadLine();

                //Fix so it doesnt crash if not integer
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
                if (Int32.TryParse(input, out var result)) //Inline variable declaration
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

        void DemoString ()
        {
            //Conversion to string  E.ToString();
            // Console.WriteLine(10); => Console.WriteLine(10.ToString());
            int hours = 10;
            string hourString = hours.ToString(); //"10"
            hourString = 10.ToString(); //"10"

            //String Literal  ""
            // escape sequence - \? inside a string literal, have special meaning to the compiler, generally produce a single character
            //  \n - newline (never use it)
            //  \t - horizontal tab
            //  \\ - slash (e.g. "C:\\Temp\\test.txt")
            // \" - double quote (e.g. "Hello \"Bob\"")
            //  \' - single quote in character
            //  \x## - hex code equivalent
            string stringLiteral = "Hello" + "World";
            stringLiteral = "Hello\nWorld";

            //Verbatim syntax - escape sequence ignored 
            string filePath = "C:\\Test\\test.txt";
            string filePath2 = @"C:\Temp\test.txt";

            //Empty string
            // null and empty string are not the same 
            string emptyString = "";
            string defaultString = null;
            bool areEqual = emptyString == defaultString; // false
            string emptyString2 = String.Empty;     // "" == String.Empty

            //Checking for empty, use String.IsNullOrEmpty
            bool isEmpty = emptyString == "";
            bool isEmpty2 = emptyString == String.Empty || emptyString == null; // IF empty or null
            bool isEmptyPreferred = String.IsNullOrEmpty(emptyString); // handles both

            // String concatenation
            //     +
            // String.Concat
            // String.Join
            string first = "Hello", second = "World";

            // start with 3 strings, (first + " "), (first + " " + second)
            string concatOp = first + " " + second;
            string concatFunction = String.Concat(first, " ", second);
            string joinFunction = String.Join(' ', first, second);

            //  Strings are immutable!!!!!!
            // 10 + 2 = 12
            string immutableString = "Hello";
            immutableString += "";  // two strings: "Hello", "Hello "
            immutableString += "World"; // three strings "Hello", "Hello ", "Hello World"

            // String Formatting 
            //      The results of 4 + 5 is 9
            int x = 4, y = 5;
            //int result = x +y;

            //  1) String concatenation - ugly and lot to type
            string format1 = "The result of " + x + " + " + y + " = " + (4+5);

            //  2) String Format
            //      -runtime overhead
            //      -missing arguements then crashes
            string format2 = String.Format("The results of {0:00} + {1:N2} = {1} = {2}", x, y, (x+y));

            // Many message- like functions have overloads that have a string and arguements and call String.Format automatically
            Console.WriteLine(format2);
            Console.WriteLine("The results of {0} + {1} = {1} = {2}", x, y, (x+y));

            //  3) String Interpolation - let the compiler do it
            //      Only works with string literals
            //      Still has the runtime overhead
            string format3 = $"The result of {x} + {y} = {x + y}";

            string formattedValue = x.ToString("00");

            decimal price = 8500;
            string priceString = price.ToString("C"); // $8,500.00

            //Common String Functions
            //  String.<function>
            //  <string>.<function>
            int len = priceString.Length; //Length, in chars, of the string . returns back the number of characters

            // Casing 
            var name = "Bob";
            string upperName = name.ToUpper();  //Upper cases string
            string lowerName = name.ToLower();  //Lower cases string

            //Comparison 
            // 1)"a" == "A" //false 
            // int to boolean functions ::=
            //      < 0 means a < b
            //      == 0 means a == b
            //      > 0 mean a > b
            // 2)string.CompareTo(string) ==> int, case sensative
            var areEqualStrings1 = name.CompareTo("bob") == 0;

            // 3) String.Compare(str, str) => int
            //    String.Compare(str, str, bool ) => int
            var areEqualString2 = String.Compare(name, "bob") == 0;
            var areEqualString3 = String.Compare(name, "bob", StringComparison.CurrentCultureIgnoreCase) == 0; // Case insensitive

            // Padding / Trimming
            //      <string.Trim() => string with all the whitespace removed from the front and back
            //      <string.TrimStart() / TrimEnd() => only from the front and back
            //      <string.PadLeft(width) / PadRight(width) => adds spaces until the given width
            string trimmedString = name.Trim();
            string trimmedPath = @"C:\Temp\test\folder1\".Trim('\\', ' ', '\t');

            string paddedString = name.PadLeft(10);

            // Manipulate Strings
            string world = "Hello World".Substring(6);
            string wor = "Hello World".Substring(6, 3);
            int index = "Hello World".IndexOf(' ');

            // Matching 
            bool startsWithSlash = @"\Temp\test.txt".StartsWith('\\');
            bool endsWithSlash = @"\Temp\test.txt".EndsWith('\\');


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

            // Primitave types in .NET map to framework types (Type Aliasing)
            // int -> Int32
            // double -> Double
            // short -> Int16
            // bool -> Boolean
            // char -> Char
            int int1 = 10;
            Int32 int2 = 20;
            int1 = int2;

            //result = int.Parse("123"); //Int32.Parse("123");
            
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
            //1. Must start with letter or underscore X
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

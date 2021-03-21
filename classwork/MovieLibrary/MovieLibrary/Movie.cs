using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    // Naming Rules
    //  Noun, no abbreviations or acronyms
    //  Pascal Cased Always

    // this keyword is only usuable inside a type
    //  it represents the current instance/object
    // it is used to distinguish class members from local identifiers

    // Accessibility - compile time access given to code (type, member, function, etc) for something 
    //  public - usable by anyone
    //  private - only usable by defining type(default for members of a class
    //  internal - (default for types): only usable in defining assembly

    // class-declaration ::= [modifiers] class identifier { members* }
    // class-members ::= field
    // field ::= [modifier] T identifier [ = E ];
    // method ::= [modifiers] (T | void) identifier ( [parameters] ) { S* }
    // modifiers ::= [public | internal]    // can only be one of the other, most will be public    

    /// <summary>Represents a movie.</summary>
    /// <remarks>
    /// Where you put additional comments that may be useful to someone 
    /// </remarks>
    public class Movie
    {
        //Methods - provide functinonality to a class (functions)
        //  Methods are verbs representing action
        //  Methods are alwatys Pascal Cased

        // this is a reference to the instace the method is being called
        //      can be used to get the current instance 
        //      never needed

        // Problems with fields 
        // 1)Can be read or written at will 
        // 2)Calculated and must be updated whenever variant values are changed
        // 3)Can never be changed from int 
        // 4)What happens if it is negative
        // 5)Cannot initialize into another field
        //public int AgeInYears = DateTime.Today - releaseYear;        
        //public int GetAgeInYears ()
        //{
        //    if (DateTime.Now.Year < ReleaseYear)
        //        return 0;
        //    return DateTime.Today.Year - ReleaseYear;
        //}
        public int AgeInYears
        {
            get 
            {
                if (DateTime.Now.Year < ReleaseYear)
                    return 0;
                return DateTime.Today.Year - ReleaseYear;
            }
            //set { }

        }
        //public void SetAgeInYears ( int year) { }


        /// <summary>Determines if movie is black and white.</summary>
        /// <returns>Returns true if the movie is black and white.</returns>
        public bool IsBlackAndWhite (/* Movie this */)
        {
            var isOld = ReleaseYear < 1940;
            //var isOld = this.releaseYear < 1940;

            ////Only case where ' this ' makes sense 
            //var title = "";
            //title = this.title;

            var note = "";
            note = Title;

            return isOld;
        }

        /// <summary>Do something complex</summary>
        /// <param name="age">The age of the movie when restored.</param>
        /// <param name="enable">Determines if movie has been restored.</param>
        private void DoComplex  ( int age, bool enable )
        { }

        /// <summary>Validates the movie data is correct.</summary>
        /// <param name="error">the error message if any.</param>
        /// <returns>True if movie is valid.</returns>
        public bool Validate (out string error)
        {

            //Title is required 
            if ( String.IsNullOrEmpty(Title))
            {
                error = "Title is required.";
                return false;
            };

            //Release year >= 1900
            if ( ReleaseYear < 1900)
            {
                error = "Release year must be >= 1900.";
                return false;           
            };

            //Run lenth >= 0
            if (RunLength < 0)
            {
                error = "Run length must be >=0.";
                return false;
            };

            error = "";
            return true;
        }

        //Properties - purpose is to expose data using methods (simple field syntax to call a complex method)
        //  Syntax starts out as a field but curly braces ( no parenthesis ) like a method
        // Use Case:
        //  1) Expose a backing field
        //  2) Calculated property = does not store data, just calculates it
        // Golden Rules:
        //  1) String and array properties never return null

        /// <summary>Gets or sets the title.</summary>
        public string Title //()
        {
            //getter - T identifier ()
            get // string get_Title()
            {
                //Return title if not null or empty string otherwise
                return (_title != null) ? _title : "";
            }
            
            //setter - void identifier ( T value ) 
            set // void set_Title ( string value ) 
            {
                _title = (value != null) ? value.Trim() : null; 
            }
        }

        //Fields - variables that store data
        // fields should always start with underscore and be camel cased
        // fields are initialized early in the process to 0, can be changed to another value
        // fields are initialized in an undefined order
        // fields cannot be initialized to another field's value
        // fields should always be preceded by an underscore
        // if you define a field always make it private(NEVER expose a field publicly

       private string _title = "";

        /// <summary>Gets or Sets the description.</summary>
       public string Description
        {
            get { return (_description != null) ? _description : ""; }
            set { _description = value; }
        }
       private string _description = "";

        /// <summary>Gets or Sets the release year.</summary>
        // public int ReleaseYear 
        // {
        //     get { return _releaseYear; }
        //     set { _releaseYear = value; }
        // }
        //private int _releaseYear = 1900;
        public int ReleaseYear { get; set; } = 1900;

       /// <summary>Gets or Sets the run length.</summary>
        //public int RunLength //Full property syntax
        // {
        //     get { return _runLength; }
        //     set { _runLength = value; }
        // }
        //private int _runLength;

        //Auto property syntax - compiler will auto generate the full property
        public int RunLength { get; set;}
        //private int _runLength;

        /// <summary>Gets or Sets the rating.</summary>
        public string Rating
        {
            get { return (_rating != null) ? _rating : ""; }
            set { _rating = value; }
        }
       private string _rating = "";
       
        /// <summary>Gets or Sets if movie is a classic.</summary>
       public bool IsClassic { get; set; }
       //public bool IsClassic
       // {
       //     get { return _isClassic; }
       //     set { _isClassic = value; }
       // }
       //private  bool _isClassic;

        // Auto properties can be setter or getter only if needed

        public int Age { get; }

        //Allowed to expose a field if const (constant)
        public const int MinimumReleaseYear = 1900;

        //public int Age { set; }
       //private string _note;
    }
}

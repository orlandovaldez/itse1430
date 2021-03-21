/*
 * CharacterCreator.ConsoleHost
 * ITSE 1430
 * Semester 2021
 * Orlando Valdez
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    /// <summary>Represents a character.</summary>
    public class Character
    {
        /// <summary>Gets or Sets Character Name.</summary>
        public string Name
        {
            get
            {
                return (_name != null) ? _name : "";
            }
            set 
            {
                _name = value;
            }
        }
        private string _name = " ";

        /// <summary>Gets or Sets Character Name.</summary>
        public string Profession
        {
            get 
            {
                return (_profession != null) ? _profession : "";
            }
            set 
            {
                _profession = value;
            }
        }
        private string _profession = "";

        /// <summary>Gets or Sets Character Name.</summary>
        public string Race
        {
            get 
            { 
                return (_race != null) ? _race : "";             
            }
            set 
            { 
                _race = value; 
            }
        }
        private string _race = "";

        /// <summary>Gets or Sets Optional Character Details.</summary>
        public string Biography
        {
            get 
            {
                return (_biography != null) ? _biography : "";            
            }
            set 
            {
                _biography = value;
            }
        }
        private string _biography = "";

        /// <summary>Gets or Sets Strength Attribute.</summary>
        public int Strength { get; set; } = 0;

        /// <summary>Gets or Sets Intelligence Attribute.</summary>

        public int Intelligence { get; set; } = 0;

        /// <summary>Gets or Sets Agility Attribute.</summary>

        public int Agility { get; set; } = 0;

        /// <summary>Gets or Sets Constitution Attribute.</summary>

        public int Constitution { get; set; } = 0;

        /// <summary>Gets or Sets Strength Attribute.</summary>

        public int Charisma { get; set; } = 0;
        
    }
}

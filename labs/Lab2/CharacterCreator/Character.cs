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
        private string _name = "";

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

        public int strength;
        public int intelligence;
        public int agility;
        public int constitution;
        public int charisma;
    }
}

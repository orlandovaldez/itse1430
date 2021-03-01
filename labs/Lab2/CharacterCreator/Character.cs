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
        public string name = "";

        /// <summary>Gets or Sets Character Name.</summary>
        public string profesion = "";

        /// <summary>Gets or Sets Character Name.</summary>
        public string race = "";

        /// <summary>Gets or Sets Optional Character Details.</summary>
        public string biography = "";

        public int strength;
        public int intelligence;
        public int agility;
        public int constitution;
        public int charisma;
    }
}

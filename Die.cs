using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DielRoller
{
    /// <summary>
    /// Represents a single six-sided die (1-6)
    /// </summary>
    public class Die

    {
        // Static field to hold a reference to one Random object
        // shared by all Die objects
        private static Random _random;

        static Die()
        {
            _random = new Random();
        }

        ///<summary>
        ///Constuctor for the die. Calls the Roll() method
        /// to set the initial value of the die.
        ///</summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// Current face value of the die/user roll
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the current die value is held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// If the die is not currently held, rolls the die and 
        /// sets the <see cref="FaceValue"/> property to the "rolled" value.
        /// </summary>
        public byte Roll()
        {
            if (IsHeld)
            {
                return FaceValue;
            }
            // If die is not held, generate a random number
            byte dieRoll = (byte)_random.Next(1, 7);

            // Set the FaceValue property
            FaceValue = dieRoll;


            return FaceValue;            
        }
    }
}

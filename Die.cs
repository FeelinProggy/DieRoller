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
        /// <summary>
        /// Current face value of the die/user roll
        /// </summary>
        public byte FaceValue { get; set; }

        /// <summary>
        /// True if the current die value is held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and returns the new "rolled" value
        /// to set the <see cref="FaceValue"/> property
        /// </summary>
        public byte Roll()
        {
            // Generate a random number
            Random random = new Random();
            byte dieRoll = (byte)random.Next(1, 7);

            // Set the FaceValue property
            FaceValue = dieRoll;


            return dieRoll;            
        }
    }
}

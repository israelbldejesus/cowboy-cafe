using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// Return the price of the RustlersRibs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// Return the calories of the entree.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the the ribsch.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }
    }
}

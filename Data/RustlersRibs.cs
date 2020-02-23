/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: RustlersRibs

* Purpose: Hold the ingredients, price, and calorie of the entree RustlersRibs

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Class which contains the entree RustlersRibs
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// Return the price of the RustlersRibs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// Return the calories of the entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the the ribsch.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Returns the representationn of this project.
        /// </summary>
        /// <returns>The string describing this class.</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}

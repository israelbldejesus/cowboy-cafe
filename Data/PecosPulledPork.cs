/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: PecosPulledPork

* Purpose: Hold the ingredients, price, and calorie of the entree PecosPulledPork

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Class which contains the entree PecosPulledPork
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// Return the price of the Pulled Pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Return the calories of the entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Sets/Returns the wether there will be a pickle.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Sets/Returns the wether there will be a bread.
        /// </summary>
        public bool Bread { get; set; } = true;//this is the same as the pickle, creating the backup variable.
        //This is known as sintactical sugar. This is very useful if you only need a get/set with nothing fancy to it.

        /// <summary>
        /// Special instructions for the preparation of the the pulled pork.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }//I can use either pickle or Pickle

                return instructions;
            }
        }
    }
}

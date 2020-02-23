/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: AngryChicken

* Purpose: Hold the ingredients, price, and calorie of the entree AngryChicken

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Class which contains the entree AngryChicken
    /// </summary>
    public class AngryChicken : Entree
    {
        /// <summary>
        /// Return the price of the AngryChicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// Return the calories of the entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool pickle = true;
        /// <summary>
        /// Sets/Returns the wether there will be a pickle.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Sets/Returns the wether there will be a bread.
        /// </summary>
        public bool Bread { get; set; } = true;//this is the same as the pickle, creating the backup variable.
        //This is known as sintactical sugar. This is very useful if you only need a get/set with nothing fancy to it.

        /// <summary>
        /// Special instructions for the preparation of the the chicken sandwich.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) { instructions.Add("hold bread"); }
                if (!pickle) { instructions.Add("hold pickle"); }//I can use either pickle or Pickle

                return instructions;
            }
        }

        /// <summary>
        /// Returns the representationn of this project.
        /// </summary>
        /// <returns>The string describing this class.</returns>
        public override string ToString()
        {
            return "Angry Chiken";
        }
    }
}

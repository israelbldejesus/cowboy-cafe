/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: TrailBurger

* Purpose: Hold the ingredients, price, and calorie of the entree TrailBurger

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Class which contains the entree TrailBurger
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// Return the price of the Trailburger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// Return the calories of the entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
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
        /// Sets/Returns the wether there will be a bun.
        /// </summary>
        public bool Bun { get; set; } = true;//this is the same as the pickle, creating the backup variable.
        //This is known as sintactical sugar. This is very useful if you only need a get/set with nothing fancy to it.

        /// <summary>
        /// Sets/Returns the wether there will be ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Sets/Returns the wether there will be mustard.
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Sets/Returns the wether there will be cheese.
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the the chicken sandwich.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) { instructions.Add("hold bun"); }
                if (!pickle) { instructions.Add("hold pickle"); }//I can use either pickle or Pickle
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }

                return instructions;
            }
        }
    }
}
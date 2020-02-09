/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: DakotaDoubleBurger

* Purpose: Hold the ingredients, price, and calorie of the entree DakotaDoubleBurger

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Class which contains the entree DakotDoubleBurger
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// Return the price of the Dakota Double Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// Return the calories of the entree.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
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
        /// Sets/Returns the wether there will be tomatoe.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Sets/Returns the wether there will be a bread.
        /// </summary>
        public bool Lettuce { get; set; } = true;//this is the same as the pickle, creating the backup variable.
        //This is known as sintactical sugar. This is very useful if you only need a get/set with nothing fancy to it.

        /// <summary>
        /// Sets/Returns the wether there will be mayo.
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the the double burger.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Mayo) { instructions.Add("hold mayo"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }//I can use either pickle or Pickle
                if (!Tomato) { instructions.Add("hold tomato"); }
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

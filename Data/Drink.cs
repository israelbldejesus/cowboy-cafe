/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: Drink

* Purpose: The base class for all the drinks.

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets/Returns weather the drink has ice. 
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the special instructions of the Drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}

/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: ChiliCheeseFries

* Purpose: Hold the ingredients, price, and calorie of the entree ChiliCheeseFries

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the side ChiliCheeseFries
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// This will return the caloreis if the side ChiliCheeseFries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// This will return the price of the side ChiliCheeseFries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the representationn of this project.
        /// </summary>
        /// <returns>The string describing this class.</returns>
        public override string ToString()
        {
            return $"{Size.ToString()} Chili Cheese Fries";
        }
    }
}

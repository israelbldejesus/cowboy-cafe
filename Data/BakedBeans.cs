/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: BakedBeans

* Purpose: Hold the price and calorie of the side BakedBeans

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the side BakedBeans
    /// </summary>
    public class BakedBeans: Side
    {
        /// <summary>
        /// This will return the caloreis if the side BakedBeans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// This will return the price of the side BakedBeans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
            return $"{Size.ToString()} Baked Beans";
        }
    }
}

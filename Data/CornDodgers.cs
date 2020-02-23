/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: CornDodgers

* Purpose: Hold the price and calorie of the side CornDodgers

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the side ConrDogers
    /// </summary>
    public class CornDodgers: Side
    {
        /// <summary>
        /// This will return the caloreis if the side ConrDogers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// This will return the price of the side ConrDogers
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
            return $"{Size.ToString()} Corn Dodgers";
        }
    }
}

/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: PanDeCampo

* Purpose: Hold the price and calorie of the side PanDeCampo

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class which contains the Side PanDeCampo
    /// </summary>
    public class PanDeCampo: Side
    {
        /// <summary>
        /// The calories for the side PanDeCampo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price for the side PanDeCampo
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
    }
}

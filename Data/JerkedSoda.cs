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
    /// A class which contains the drink Water.
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Contains the flavour of the drink.
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// The calories for the drink JerkedSoda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price for the drink JerkedSoda
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// This will return the Special Isnnstructions for the Drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> inst = new List<string>();

                if (!Ice) inst.Add("Hold Ice");

                return inst;
            }
        }

        /// <summary>
        /// Returns the representationn of this project.
        /// </summary>
        /// <returns>The string describing this class.</returns>
        public override string ToString()
        {
            switch (Flavor)
            {
                case (SodaFlavor.BirchBeer):
                    return $"{Size.ToString()} Birch Beer Jerked Soda";
                case (SodaFlavor.CreamSoda):
                    return $"{Size.ToString()} Cream Soda Jerked Soda";
                case (SodaFlavor.OrangeSoda):
                    return $"{Size.ToString()} Orange Soda Jerked Soda";
                case (SodaFlavor.RootBeer):
                    return $"{Size.ToString()} Root Beer Jerked Soda";
                case (SodaFlavor.Sarsparilla):
                    return $"{Size.ToString()} Sarsparilla Jerked Soda";
                default:
                    return $"{Size.ToString()} Soda";
            }
        }
    }
}

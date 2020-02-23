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
    public class Water : Drink
    {
        /// <summary>
        /// This will retun/set weather the Drink will have a Lamon.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The calories for the drink Water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0 ;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price for the drink Water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
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

                if (Lemon) inst.Add("Add Lemon");
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
            return $"{Size.ToString()} Water";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class which contains the drink CowboyCoffee.
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The calories for the drink CowboyCoffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price for the drink CowboyCoffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// This will retun/set weather the Drink will have Cream.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// This will retun/set weather the Drink will be decaf.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// This will retun/set weather the Drink will have Cream.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// This will return the Special Isnnstructions for the Drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> inst = new List<string>();

                if (RoomForCream) inst.Add("Room for Cream");
                if (Ice) inst.Add("Add Ice"); 

                return inst;
            }
        }

        /// <summary>
        /// Returns the representationn of this project.
        /// </summary>
        /// <returns>The string describing this class.</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{Size} Decaf Cowboy Coffee";
            }
            return $"{Size} Cowboy Coffee";
        }
    }
}

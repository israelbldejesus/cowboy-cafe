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

                if (Ice) inst.Add("Hold Ice");

                return inst;
            }
        }
    }
}

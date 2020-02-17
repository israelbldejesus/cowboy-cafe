using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class which contains the drink TexasTea.
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// This will retun/set weather the Drink will be sweet.
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// This will retun/set weather the Drink will have lemon.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The calories for the drink TexasTea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (!Sweet)
                        {
                            return 10 / 2;
                        }
                        return 10;
                    case Size.Medium:
                        if (!Sweet)
                        {
                            return 22 / 2;
                        }
                        return 22;
                    case Size.Large:
                        if (!Sweet)
                        {
                            return 36 / 2;
                        }
                        return 36;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price for the drink TexasTea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                if (Ice) inst.Add("Hold Ice");

                return inst;
            }
        }
    }
}

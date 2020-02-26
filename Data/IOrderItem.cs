using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface 
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price for this order
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The specialninstructions for the order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}

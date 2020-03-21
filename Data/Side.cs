/*

* Author: Israel B. Lopez De Jesus

* Edited by: Israel B. Lopez De Jesus

* Class name: Side

* Purpose: The base class for all the sides.

*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private Size size;
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size 
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }
    }
}

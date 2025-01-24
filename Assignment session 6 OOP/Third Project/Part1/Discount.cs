using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Third_Project.Part1
{
    internal abstract class Discount
    {

        #region Properties
        //A Name property to store the type of discount.
        public string? Name { get; set; }
        #endregion


        #region Methods
        //An abstract method CalculateDiscount(decimal price, int quantity) that returns the discount amount based on the original price and quantity.
        public abstract decimal CalculateDiscount(decimal price, int quantity);

        #endregion
    }
}

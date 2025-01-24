using Assignment_session_6_OOP.Third_Project.Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Third_Project.Part2
{
    internal class PercentageDiscount : Discount
    {
        #region Properties
        public decimal Percentage { get;}

        #endregion

        #region Constructors
        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
        }
        #endregion
        #region Methods
        //Accepts a percentage (e.g., 10%).
        //Formula: Discount Amount = Price×Quantity×(Percentage/100)
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            decimal DiscountAmount = (price * quantity) * (Percentage / 100); //calculating the discount

            return DiscountAmount;
        }

        #endregion
    }
}

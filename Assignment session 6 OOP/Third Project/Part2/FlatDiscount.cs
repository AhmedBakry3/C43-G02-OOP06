using Assignment_session_6_OOP.Third_Project.Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Third_Project.Part2
{
    internal class FlatDiscount : Discount
    {
        #region Properties
        //// Fixed discount amount
        public decimal FlatAmount { get; }


        #region Constructors
        public FlatDiscount(decimal flatAmount)
        {
            FlatAmount = flatAmount;
        }
        #endregion

        #endregion
        #region Methods
        //Accepts a fixed amount to be deducted(e.g., $50).
        //Formula: Discount Amount = Flat Amount×min(Quantity, 1)

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            decimal DiscountAmount = FlatAmount * decimal.Min(quantity, 1); //calculating the discount

            return DiscountAmount;
        }
        #endregion
    }
}

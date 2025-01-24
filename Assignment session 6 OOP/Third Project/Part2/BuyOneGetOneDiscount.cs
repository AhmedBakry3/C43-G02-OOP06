using Assignment_session_6_OOP.Third_Project.Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Third_Project.Part2
{

    internal class BuyOneGetOneDiscount : Discount
    {
        #region Methods
        //Applies a 50% discount if the quantity is greater than 1.
        //Formula: Discount Amount = (Price / 2)×(Quantity÷2)


        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            decimal DiscountAmount=0;
            if (quantity > 1)
            {
                 DiscountAmount = (price / 2) * (quantity / 2);//calculating the discount
            }
                return DiscountAmount;
            
        }
        #endregion
    }
}

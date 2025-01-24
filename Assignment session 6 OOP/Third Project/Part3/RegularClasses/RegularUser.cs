using Assignment_session_6_OOP.Third_Project.Part1;
using Assignment_session_6_OOP.Third_Project.Part2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Third_Project.Part3.RegularClasses
{
    internal class RegularUser : User
    {
        #region Methods
        //RegularUser: Applies a PercentageDiscount of 5%.
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5); // Regular user gets 5% discount

        }
        #endregion

    }
}

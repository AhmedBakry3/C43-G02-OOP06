using Assignment_session_6_OOP.Third_Project.Part1;
using Assignment_session_6_OOP.Third_Project.Part2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Third_Project.Part3.RegularClasses
{
    internal class PremiumUser : User
    {
        #region Methods
        //PremiumUser: Applies a FlatDiscount of $100.
        public override Discount GetDiscount()
        {
  
            return new FlatDiscount(100); // Premium user gets $100 discount

        }
        #endregion

    }
}

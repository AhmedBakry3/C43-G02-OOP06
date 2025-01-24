using Assignment_session_6_OOP.Third_Project.Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Third_Project.Part3.RegularClasses
{
    internal class GuestUser : User
    {
        #region Methods
        //GuestUser: No discount is applied
        public override Discount GetDiscount()
        {
            return null;
        }
        #endregion

    }
}

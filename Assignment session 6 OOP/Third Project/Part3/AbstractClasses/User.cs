using Assignment_session_6_OOP.Third_Project.Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Third_Project.Part3
{
    internal abstract class User
    {
        #region Properties
        //A Name property to store the user name.
        public string? UseraName { get; set; }
        #endregion

        #region Methods
        //An abstract method GetDiscount() that returns a Discount object.
        public abstract Discount GetDiscount();
        #endregion

    }
}

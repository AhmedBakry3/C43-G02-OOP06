using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.Second_Project
{
    internal static class Maths
    {
        #region Methods
        //Add Method
        public static double Add(double X, double Y)
        {
            return X + Y;   
        }

        //Subtract Method
        public static double Subtract(double X, double Y)
        {
            return X - Y;
        }
        //Multiply Method
        public static double Multiply(double X, double Y)
        {
            return X * Y;
        }
        public static double Divide(double X, double Y)
        {
            if (Y == 0)
            {
                Console.WriteLine("You Can't Division by zero");
                return double.NaN;  // Return 'Not a Number' when dividing by zero
            }
            return X / Y;
        }

        #endregion

    }
}

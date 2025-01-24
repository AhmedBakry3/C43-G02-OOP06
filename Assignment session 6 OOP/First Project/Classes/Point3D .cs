using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_session_6_OOP.First_Project.Classes
{
    internal class Point3D : ICloneable , IComparable<Point3D>   
    {

        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        #endregion

        #region Constructors
        //basic Constructor
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        //Constructor Chaning 
        public Point3D(double x, double y) : this(x, y , 5)
        {
            X=x; 
            Y=y;
        }
        public Point3D(double z) : this(1,2,z)
        {
            Z = z;
        }
        #endregion


        #region Methods

        //override at tostring() Method
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        //static Method to let user to enter the 2 points Coordinates using tryParse
        public static double GetCoordinateUsingTryParse(string coordinateName)
        {
            double coordinate;
            bool isParsed;
            do
            {
                Console.Write($"Enter {coordinateName}: ");
                isParsed = double.TryParse(Console.ReadLine(), out coordinate);
                if (!isParsed)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid Number");
                }
            } while (!isParsed);

            return coordinate;
        }

        //static Method to let user to enter the 2 points Coordinates using Parse
        public static double GetCoordinateUsingParse(string coordinateName)
        {
            double coordinate = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write($"Enter {coordinateName}: ");

                try
                {
                    coordinate = double.Parse(Console.ReadLine() ?? ""); 
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid Number");
                }
            }
            return coordinate;

        }

        //static Method to let user to enter the 2 points Coordinates using Covert
        public static double GetCoordinateUsingConvert(string coordinateName)
        {
            double coordinate = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write($"Enter {coordinateName}: ");

                try
                {
                    coordinate = Convert.ToDouble(Console.ReadLine() ?? "");
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid Number");
                }
            }
            return coordinate;

        }
        //ParamterLess Constructor 
        public Point3D()
        {
            
        }
        //Implementing ICloneable Interface
        public object Clone()
        {
            return new Point3D { X = X, Y = Y , Z=Z };
        }
        //Implementing IComparable<Point3D> Interface
        public int CompareTo(Point3D? Point)
        {
            if (Point == null)
                return 1;  //If the Object Point is Null , it means this Object Is Greater

            // First compare by X coordinate
            int xComparison = this.X.CompareTo(Point.X);

            // If X is the same, compare by Y coordinate
            if (xComparison != 0)
                return xComparison;

            return this.Y.CompareTo(Point.Y);  // Compare Y if X is the same
        }
        #endregion
    }
}

using Assignment_session_6_OOP.First_Project.Classes;
using Assignment_session_6_OOP.Second_Project;
using Assignment_session_6_OOP.Third_Project.Part1;
using Assignment_session_6_OOP.Third_Project.Part2;
using Assignment_session_6_OOP.Third_Project.Part3;
using Assignment_session_6_OOP.Third_Project.Part3.RegularClasses;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Assignment_session_6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project


            #region 1.Define 3D Point Class and the basic Constructors (use chaining in constructors).

            // In this Question , I Created Point3D CLass and its basic constructors and chaining in constructors
            #endregion

            #region 2.Override the ToString Function to produce this output:
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            //Output: “Point Coordinates: (10, 10, 10)”.


            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString()); //Point Coordinates: (10, 10, 10)

            #endregion

            #region 3.Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            //Check the input using try Parse

            //Declaring 3 Variables x1, y1, z1
            double x1;
            double y1;
            double z1;

            //Entering Coordinates (x,y,z) For Point 1 
            x1 = Point3D.GetCoordinateUsingTryParse("x1");
            y1 = Point3D.GetCoordinateUsingTryParse("y1");
            z1 = Point3D.GetCoordinateUsingTryParse("z1");

            //Creating Instances From "P1"
            Point3D P1 = new Point3D(x1, y1, z1);
            Console.WriteLine($"You entered for Point 1: {P1}"); //You entered for Point 1 : Point Coordinates: (3.3, 4.5, 5.5)

            //////Declaring 3 Variables x2,y2,z2
            double x2;
            double y2;
            double z2;

            //Entering Coordinates (x,y,z) For Point 2
            x2 = Point3D.GetCoordinateUsingTryParse("x2");
            y2 = Point3D.GetCoordinateUsingTryParse("y2");
            z2 = Point3D.GetCoordinateUsingTryParse("z2");

            //Creating Instances From "P2"
            Point3D P2 = new Point3D(x2, y2, z2);
            Console.WriteLine($"You entered for Point 2: {P2}"); //You entered for Point 2 : Point Coordinates: (6.2, 7.1, 8.9)


            //Check the input using Parse

            //Entering Coordinates (x,y,z) For Point 1
            x1 = Point3D.GetCoordinateUsingParse("x1");
            y1 = Point3D.GetCoordinateUsingParse("y1");
            z1 = Point3D.GetCoordinateUsingParse("z1");

            //Creating Instances From "P1"
            Point3D P1 = new Point3D(x1, y1, z1);
            Console.WriteLine($"You entered for Point 1: {P1}"); //You entered for Point 1 : Point Coordinates: (3.3, 4.5, 5.5)

            //Entering Coordinates (x,y,z) For Point 2
            x2 = Point3D.GetCoordinateUsingParse("x2");
            y2 = Point3D.GetCoordinateUsingParse("y2");
            z2 = Point3D.GetCoordinateUsingParse("z2");

            //Creating Instances From "P2"
            Point3D P2 = new Point3D(x2, y2, z2);
            Console.WriteLine($"You entered for Point 2: {P2}"); //You entered for Point 2 : Point Coordinates: (6.2, 7.1, 8.9)


            //Check the input using Convert

            //Entering Coordinates (x,y,z) For Point 1
            x1 = Point3D.GetCoordinateUsingConvert("x1");
            y1 = Point3D.GetCoordinateUsingConvert("y1");
            z1 = Point3D.GetCoordinateUsingConvert("z1");

            //Creating Instances From "P1"
            Point3D P1 = new Point3D(x1, y1, z1);
            Console.WriteLine($"You entered for Point 1: {P1}"); //You entered for Point 1 : Point Coordinates: (3.3, 4.5, 5.5)

            //Entering Coordinates (x,y,z) For Point 2
            x2 = Point3D.GetCoordinateUsingConvert("x2");
            y2 = Point3D.GetCoordinateUsingConvert("y2");
            z2 = Point3D.GetCoordinateUsingConvert("z2");

            //Creating Instances From "P2"
            Point3D P2 = new Point3D(x2, y2, z2);
            Console.WriteLine($"You entered for Point 2: {P2}"); //You entered for Point 2 : Point Coordinates: (6.2, 7.1, 8.9)


            #endregion

            #region 4.Try to use  == If(P1 == P2)   Does it work properly? 

            if (P1 == P2)
            {
                Console.WriteLine("Its Work");
            }
            else
            {
                Console.WriteLine("It doesnt work"); //It doesn't work because the '==' operator compares object references by default. Even if the values are the same, they are considered different objects in memory unless you override the Equals() and GetHashCode() methods to compare their contents
            }

            #endregion


            #region 5.Define an array of points and sort this array based on X & Y coordinates.

            //Create an array of Point3D objects
            Point3D[] points = new Point3D[]
            {
                new Point3D(2, 3, 4),
                new Point3D(1, 2, 3),
                new Point3D(3, 1, 5),
                new Point3D(2, 2, 6)
            };
            Array.Sort(points);

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }
            #endregion

            #region 6.Implement ICloneable interface to be able to clone the object.

            P2 = (Point3D)P1.Clone();
            Console.WriteLine(P1);
            Console.WriteLine(P2);

            #endregion

            #endregion

            #region Second Project

            #region Question 1 : Define Class Maths that has four methods:
            //Add()
            //Subtract()
            //Multiply()
            //Divide()
            //Each of them takes two parameters. Call each method in Main().
            //NOTE : Modify the program so that you do not have to create an instance of class to call the four methods.

            //since they are in static class so all their member in this class are static , so we cant create instance from this class , so since they are static Methods they are Class Member , they will be called by class name

            //Calling the Add Method
            Console.WriteLine(Maths.Add(1.5, 4.5)); //6

            //Calling the Subtract Method 
            Console.WriteLine(Maths.Subtract(10.5, 7.5)); //3

            //Calling the Multiply Method 
            Console.WriteLine(Maths.Multiply(5.5 ,6.5)); //35.75

            //Calling the Divide Method 
            Console.WriteLine(Maths.Divide(22.5, 8.5)); //2.6470588235294117

            #endregion


            #endregion

            #region Third Project

            //You are tasked with designing a system for an e-commerce platform that calculates discounts for different types of users and products.
            //This system should utilize abstraction and include the following parts:

            #region Part 1: Abstract Discount class MyClass
            //Create an abstract class Discount with:
            //An abstract method CalculateDiscount(decimal price, int quantity) that returns the discount amount based on the original price and quantity.
            //A Name property to store the type of discount.


            //In Part 1 , I Created the abstract Class with its property & its Abstract Method CalculateDiscount(decimal price, int quantity)
            #endregion


            #region Part 2: Specific Discounts
            //Implement the following concrete discount classes:
            //PercentageDiscount:
            //Accepts a percentage(e.g., 10 %).
            //Formula: Discount Amount = Price×Quantity×(Percentage / 100)
            //FlatDiscount:
            // Accepts a fixed amount to be deducted(e.g., $50).
            //Formula: Discount Amount = Flat Amount×min(Quantity, 1)
            //BuyOneGetOneDiscount:
            //Applies a 50 % discount if the quantity is greater than 1.
            // Formula: Discount Amount = (Price / 2)×(Quantity÷2)


            //In Part 2 , I Created 3 Concrete Discount Classes that implement the abstract method in discount class
            #endregion

            #region Part 3 Discount Applicability

            //Create an abstract class User with:
            //A Name property to store the user name.
            //An abstract method GetDiscount() that returns a Discount object.
            //Implement the following specific user types:
            //RegularUser: Applies a PercentageDiscount of 5%.
            //PremiumUser: Applies a FlatDiscount of $100.
            //GuestUser: No discount is applied

            //In Part 3 , I Created Abstract Class user and its property and its abstract Method GetDiscount()
            //I Created 3 Users Types that Implement the user abstract Method GetDiscount() which returns a discount object
            #endregion

            #region Part 4: Integration
            //Write a program that:
            //Ask the user to input their type(Regular, Premium, or Guest).
            //Allows the user to input product details(price and quantity).
            //Calculates and displays the total discount and final price after applying the appropriate discount.

            bool isParsed;
            decimal price = 0;
            int quantity = 0;

            // Ask for the user type
            Console.WriteLine("What are you? [Regular] or [Premium] or [Guest]: ");
            string userType = Console.ReadLine() ?? "";

            User user = null;

            if (userType == "Regular")
            {
                user = new RegularUser();
            }
            else if (userType == "Premium")
            {
                user = new PremiumUser();
            }
            else if (userType == "Guest")
            {
                user = new GuestUser();
            }
            else
            {
                Console.WriteLine("Sorry, we don't know you.");
                return;
            }

            // Get product details (price and quantity)
            do
            {
                Console.Write("Please enter the product price: ");
                isParsed = decimal.TryParse(Console.ReadLine(), out price);
                if (!isParsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid price.");
                }
            } while (!isParsed);

            do
            {
                Console.Write("Please enter the product quantity: ");
                isParsed = int.TryParse(Console.ReadLine(), out quantity);
                if (!isParsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid quantity.");
                }
            } while (!isParsed);

            // Get the discount for the user
            Discount discount = user.GetDiscount();

            if (discount is not null)
            {
                decimal discountAmount = discount.CalculateDiscount(price, quantity);
                decimal finalPrice = price * quantity - discountAmount;

                Console.WriteLine($"Discount applied: {discountAmount:C}");
                Console.WriteLine($"Final price after discount: {finalPrice:C}");
            }
            else
            {
                Console.WriteLine("No discount available for Guest users");
                decimal finalPrice = price * quantity;
                Console.WriteLine($"Final price: {finalPrice:C}");
            }

            #endregion

            #endregion
        }
    }
}

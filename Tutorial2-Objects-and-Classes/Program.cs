/**
 * OOP Tutorial 2
 * A Review on Objects and Classes (Brings a C++ Program into C#)
 * 
 * @author  Nick Sturch-Flint
 * @since   2021-01-24
 * @version 1.0.0
 * 
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetValidMethods;

namespace Tutorial2_Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Set a Limit
                CartesianPoint.Limit = 99;
                //Create Two Points
                CartesianPoint thePoint = new CartesianPoint();
                CartesianPoint anotherPoint = new CartesianPoint(3, 4);

                //Print the distance between two points
                Console.WriteLine("The distance between {0} and {1} is {2:F2}.", thePoint, anotherPoint, thePoint - anotherPoint);

                //Updating Points (property sets)
                thePoint.X = 99;
                thePoint.Y = 98;

                //Set X and Y using mutators
                anotherPoint.SetPoint(99, 90);

                //Print the distance between two points
                Console.WriteLine("The distance between {0} and {1} is {2:F2}.", thePoint, anotherPoint, thePoint - anotherPoint);

                //Reset the original point back
                thePoint.SetPoint(0, 0);

                //Set X and Y using user input
                Console.Write("X: ");
                anotherPoint.X = GetValid.WholeNumber(-CartesianPoint.Limit, CartesianPoint.Limit);
                Console.Write("Y: ");
                anotherPoint.Y = GetValid.WholeNumber(-CartesianPoint.Limit, CartesianPoint.Limit);

                //Print the distance between two points
                Console.WriteLine("The distance between {0} and {1} is {2:F2}.", thePoint, anotherPoint, thePoint - anotherPoint);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n{0}\n{1}", e.GetType(), e.Message);
            }

            //End Program
            Console.WriteLine("\nPress Any Key To Continue");
            Console.ReadKey();
        }
    }
}

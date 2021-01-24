/**
 * Cartesian Point Class
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

namespace Tutorial2_Objects_and_Classes
{
    public class CartesianPoint
    {
        //CONSTANTS
        private static int theLimit = 100; 
        /// <summary>
        /// Constructor for the Min and Max Coordinate Values
        /// </summary>
        public static int Limit
        {
            get { return theLimit;  }
            set { theLimit = value; }
        }

        //VARIABLES
        private int myX;
        private int myY;

        //ACCESSORS
        /// <summary>
        /// Getter and Setter for X
        /// </summary>
        public int X
        {
            get { return myX;  }
            set
            {
                //Validation
                if (value >= -Limit && value <= Limit)
                {
                    myX = value;
                }
                else
                {
                    throw (new ArgumentOutOfRangeException("X", value, "X Value must be assigned between +/- 100."));
                }

            }
        }
        /// <summary>
        /// Getter and Setter for Y
        /// </summary>
        public int Y
        {
            get { return myY;  }
            set 
            {
                //Validation
                if (value >= -Limit && value <= Limit)
                {
                    myY = value;
                }
                else 
                {
                    throw (new ArgumentOutOfRangeException("Y", value, "Y Value must be assigned between +/- 100."));
                }
                 
            }
        }

        //CONSTRUCTORS
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="x">Coordinate</param>
        /// <param name="y">Coordinate</param>
        public CartesianPoint(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Method that modifies and existing object
        /// </summary>
        /// <param name="x">New Coordinate</param>
        /// <param name="y">New Coordinate</param>
        public void SetPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Overrides the ToString Method to print out the CartesianPoint Object
        /// </summary>
        /// <returns>The X and Y Coordinates</returns>
        public override string ToString()
        {
            return string.Format("({0:F0}, {1:F0})", myX, myY);
        }
        /// <summary>
        /// operator-(CartesianPoint, CartesianPoint) - Calculates the distance between two points
        /// </summary>
        /// <param name="pointA">First Coordinate</param>
        /// <param name="pointB">Second Coordinate</param>
        /// <returns></returns>
        public static double operator -(CartesianPoint pointA, CartesianPoint pointB)
        {
            //return the formula based on pythagorean
            return Math.Sqrt(
                (pointA.myX - pointB.myX) * (pointA.myX - pointB.myX) +
                (pointA.myY - pointB.myY) * (pointA.myY - pointB.myY));
        }
    }
}

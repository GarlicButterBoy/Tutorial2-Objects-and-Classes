/**
 * OOP Tutorial 2
 * A Class Library that holds methods we want to use in our main program
 * 
 * @author  Nick Sturch-Flint
 * @since   2021-01-24
 * @version 1.0.0
 * 
 */

using System;

namespace GetValidMethods
{
    /// <summary>
    /// A Static Class that provides convenient methods to validate numeric input
    /// </summary>
    public static class GetValid
    {
        /// <summary>
        /// A method to get a validated integer from the console
        /// </summary>
        /// <param name="min">The Min accepted value</param>
        /// <param name="max">The Max accepted value</param>
        /// <returns>A validated Integer</returns>
        public static int WholeNumber(int min = int.MinValue, int max = int.MaxValue)
        {
            string userInput;    //Sequence of character the user inputs
            int numbersReturned; //Converted Numeric Value

            //Store user input as string
            userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out numbersReturned))
            {
                //Show the input and explain the issue
                Console.WriteLine("\"{0}\" could not be parsed into a whole number.", userInput);
                //Prompt to try again
                Console.Write("Please Try Again: ");
                //Restart the method using recursion
                numbersReturned = WholeNumber(min, max);
            }
            else if (numbersReturned < min || numbersReturned > max)
            {
                //Show the input and explain the issue
                Console.WriteLine("\"{0}\" must be between {1} and {2}.", userInput, min, max);
                //Prompt to try again
                Console.Write("Please Try Again: ");
                //Restart the method using recursion
                numbersReturned = WholeNumber(min, max);
            }
            //return valid number
            return numbersReturned;
        }

        /// <summary>
        /// A method to get a validated double from the console
        /// </summary>
        /// <param name="min">The Min accepted value</param>
        /// <param name="max">The Max accepted value</param>
        /// <returns>A validated Double</returns>
        public static double RealNumber(double min = -double.MaxValue, double max = double.MaxValue)
        {
            string userInput;    //Sequence of character the user inputs
            double numbersReturned; //Converted Numeric Value

            //Store user input as string
            userInput = Console.ReadLine();

            if (!double.TryParse(userInput, out numbersReturned))
            {
                //Show the input and explain the issue
                Console.WriteLine("\"{0}\" could not be parsed into a whole number.", userInput);
                //Prompt to try again
                Console.Write("Please Try Again: ");
                //Restart the method using recursion
                numbersReturned = RealNumber();
            }
            else if (numbersReturned < min || numbersReturned > max)
            {
                //Show the input and explain the issue
                Console.WriteLine("\"{0}\" must be between {1} and {2}.", userInput, min, max);
                //Prompt to try again
                Console.Write("Please Try Again: ");
                //Restart the method using recursion
                numbersReturned = RealNumber(min, max);
            }
            //return valid number
            return numbersReturned;
        }

    }
}

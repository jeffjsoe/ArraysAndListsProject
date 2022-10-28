//-JESUS
using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * 
             * 
             * 
             * Name one List "evens"
             * Name the other List "odds"
             */

            var even = new List<int> { };
            var odd = new List<int> { };

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach(var number in numbers)
            {
                if (number % 2 == 0)
                {
                    //-Here we are checking if the reminder of number is 2 then we are adding it to the number list
                    even.Add(number);

                }

                else
                {
                    //Here we are adding the odd numbers to the odd list
                    odd.Add(number);

                }


            }
            for (int i=0; i<even.Count; i++)
            {
                //So here we created a indes called i. Which is less than the total amount of even numbers in list. 
                Console.WriteLine(even[i]);

            }


            for (int j=0; j<odd.Count; j++)
            {

                Console.WriteLine(odd[j]);

            }
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}

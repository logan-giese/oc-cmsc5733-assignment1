using System;
using System.Collections.Generic;

namespace OC_CMSC_5733_Assignment_1
{
    // Squashes a list of numbers into a single value via addition
    class NumberListSquasher
    {
        static void Main(string[] args)
        {
            // Test data
            int[] nums = { 3, 4, 5, 7, 8, 9, 42 }; // Sum should be 78, product should be 1,270,080

            // Test summation
            Console.WriteLine("== Number List Squasher ==\n");
            Console.WriteLine("List sum = " + Sum(nums));
        }

        /// <summary>
        /// Find the sum of a list of numbers
        /// </summary>
        static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }
    }
}

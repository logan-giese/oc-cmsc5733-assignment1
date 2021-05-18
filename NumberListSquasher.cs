using System;
using System.Collections.Generic;

namespace OC_CMSC_5733_Assignment_1
{
    // Squashes a list of numbers into a single value via addition or multiplication
    class NumberListSquasher
    {
        static void Main(string[] args)
        {
            // Test data
            int[] nums = { 3, 4, 5, 7, 8, 9, 42 }; // Sum should be 78, product should be 1,270,080

            // Run tests
            Console.WriteLine("== Number List Squasher ==\n");
            Console.WriteLine("List sum\t= " + Sum(nums));
            Console.WriteLine("List product\t= " + Product(nums));
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

        /// <summary>
        /// Find the product of a list of numbers
        /// </summary>
        static int Product(int[] numbers)
        {
            int product = numbers.Length > 0 ? numbers[0] : 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
    }
}

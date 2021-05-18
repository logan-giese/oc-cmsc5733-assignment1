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
            Console.WriteLine("List: 3, 4, 5, 7, 8, 9, 42");
            Console.WriteLine("List sum\t= " + Sum(nums));
            Console.WriteLine("List product\t= " + Product(nums));

            Console.Write("List reversed\t= ");
            int[] numsReversed = Reverse(nums);
            foreach (int n in numsReversed)
                Console.Write(n + " ");
            Console.Write("\n");

            // Get user-entered numbers
            List<int> nums2 = new List<int>();
            Console.WriteLine("\n-- Enter your own numbers --\n(Enter a blank line to finish)\n");
            string input;
            while ((input = Console.ReadLine()) != "")
            {
                nums2.Add(Int32.Parse(input));
            }

            // Test with user-entered numbers
            Console.WriteLine("List sum\t= " + Sum(nums2.ToArray()));
            Console.WriteLine("List product\t= " + Product(nums2.ToArray()));

            Console.Write("List reversed\t= ");
            int[] nums2Reversed = Reverse(nums2.ToArray());
            foreach (int n in nums2Reversed)
                Console.Write(n + " ");
            Console.Write("\n");
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

        /// <summary>
        /// Reverse the order of a list of numbers
        /// </summary>
        static int[] Reverse(int[] numbers)
        {
            int[] newNums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                newNums[numbers.Length - 1 - i] = numbers[i];
            }
            return newNums;
        }
    }
}

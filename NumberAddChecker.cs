using System;
using System.Collections.Generic;

namespace OC_CMSC_5733_Assignment_1
{
    // Class with verification methods for addition of number lists
    public class NumberAddChecker
    {
		// Checks whether some two numbers in "numbers" can be added to get "target"
        public static bool CanAddTo(int[] numbers, int target)
		{
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int a = numbers[i];
                    int b = numbers[j];
                    if ((a + b) == target)
                        return true;
                }
            }
            return false;
		}
    }
}

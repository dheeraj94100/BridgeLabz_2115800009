using System;
using System.Collections.Generic;

class Program
{
    public static bool HasPairWithSum(int[] arr, int targetSum)
    {
        HashSet<int> visited = new HashSet<int>();

        foreach (int num in arr)
        {
            int complement = targetSum - num;

            // If complement exists, return true
            if (visited.Contains(complement))
            {
                return true;
            }

            visited.Add(num);  // Add current number to the set
        }

        return false;  // No pair found
    }

    static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int targetSum = 17;

        Console.WriteLine(HasPairWithSum(arr, targetSum));  // Output: True
    }
}

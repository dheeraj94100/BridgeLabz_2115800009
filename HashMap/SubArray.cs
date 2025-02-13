using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, int> sumMap = new Dictionary<int, int>();
        int sum = 0;

        // Traverse the array and compute cumulative sum
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            // If sum is zero, there is a subarray from 0 to i
            if (sum == 0)
            {
                Console.WriteLine("Subarray [0, " + i + "]");
            }

            // If sum repeats, there is a zero-sum subarray
            if (sumMap.ContainsKey(sum))
            {
                for (int j = sumMap[sum] + 1; j <= i; j++)
                {
                    Console.WriteLine("Subarray [" + j + ", " + i + "]");
                }
            }

            // Store the current cumulative sum and its index
            sumMap[sum] = i;
        }
    }

    static void Main()
    {
        int[] arr = { 6, -3, 1, 3, -2, 2, 4 };
        FindZeroSumSubarrays(arr);
    }
}

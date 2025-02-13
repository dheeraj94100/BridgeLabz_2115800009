using System;
using System.Collections.Generic;

class TwoSum
{
    public static int[] FindTwoSumIndices(int[] arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[arr[i]] = i;
        }

        return null;  // Return null if no such pair is found
    }

    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;
        var result = FindTwoSumIndices(arr, target);

        if (result != null)
        {
            Console.WriteLine("Indices: " + result[0] + ", " + result[1]);  // Output: Indices: 0, 1
        }
        else
        {
            Console.WriteLine("No pair found");
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    public static int LongestConsecutiveSequence(int[] arr)
    {
        if (arr.Length == 0) return 0;

        HashSet<int> set = new HashSet<int>(arr);
        int longestSequence = 0;

        foreach (int num in arr)
        {
            if (!set.Contains(num - 1))  // Check if it's the start of a sequence
            {
                int currentNum = num;
                int currentStreak = 1;

                while (set.Contains(currentNum + 1))  // Count consecutive elements
                {
                    currentNum++;
                    currentStreak++;
                }

                longestSequence = Math.Max(longestSequence, currentStreak);  // Update the longest sequence
            }
        }

        return longestSequence;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine(LongestConsecutiveSequence(arr));  // Output: 4
    }
}

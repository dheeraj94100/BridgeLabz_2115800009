using System;

class Program
{
    static void Main()
    {
        // Take input from the user for the array
        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Find the first missing positive integer
        int missingPositive = FindFirstMissingPositive(arr);
        Console.WriteLine($"The first missing positive integer is: {missingPositive}");
    }

    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;

        // Step 1: Mark non-positive numbers as irrelevant
        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= 0 || arr[i] > n)
            {
                arr[i] = n + 1; // Mark as irrelevant
            }
        }

        // Step 2: Mark the presence of each number in the array
        for (int i = 0; i < n; i++)
        {
            int num = Math.Abs(arr[i]);
            if (num <= n)
            {
                arr[num - 1] = -Math.Abs(arr[num - 1]); // Mark as visited
            }
        }

        // Step 3: Find the first missing positive integer
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                return i + 1;
            }
        }

        // If all numbers from 1 to n are present, return n + 1
        return n + 1;
    }
}
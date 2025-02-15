using System;

class Program
{
    static void Main()
    {
        // Take input from the user for the array
        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array (sorted):");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Take input from the user for the target element
        Console.WriteLine("Enter the target element:");
        int target = Convert.ToInt32(Console.ReadLine());

        // Find the first and last occurrence of the target element
        int firstOccurrence = FindFirstOccurrence(arr, target);
        int lastOccurrence = FindLastOccurrence(arr, target);

        // Display the results
        if (firstOccurrence != -1)
        {
            Console.WriteLine($"First occurrence of {target} is at index {firstOccurrence}");
            Console.WriteLine($"Last occurrence of {target} is at index {lastOccurrence}");
        }
        else
        {
            Console.WriteLine($"Element {target} is not found in the array.");
        }
    }

    static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1; // Look for the first occurrence on the left side
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1; // Look for the last occurrence on the right side
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}
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

        // Sort the array for binary search
        Array.Sort(arr);

        // Take input from the user for the target element
        Console.WriteLine("Enter the target element to search:");
        int target = Convert.ToInt32(Console.ReadLine());

        // Find the index of the target element using binary search
        int targetIndex = BinarySearch(arr, target);

        if (targetIndex != -1)
        {
            Console.WriteLine($"The target element {target} is found at index {targetIndex}.");
        }
        else
        {
            Console.WriteLine($"The target element {target} is not found in the array.");
        }
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid; // Return the index if the target is found
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

        return -1; // Return -1 if the target is not found
    }
}
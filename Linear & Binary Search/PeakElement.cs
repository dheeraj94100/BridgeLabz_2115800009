using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the size of the array
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Initialize the array
        int[] array = new int[size];

        // Prompt the user to enter the elements of the array
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Perform binary search to find a peak element
        int peakIndex = FindPeakElement(array);

        // Display the result
        if (peakIndex != -1)
        {
            Console.WriteLine($"A peak element is {array[peakIndex]} at index {peakIndex}.");
        }
        else
        {
            Console.WriteLine("No peak element found in the array.");
        }
    }

    static int FindPeakElement(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        // Perform binary search
        while (left < right)
        {
            int mid = left + (right - left) / 2;

            // Check if the mid element is a peak
            if (array[mid] > array[mid + 1])
            {
                // If mid is greater than its right neighbor, search the left half
                right = mid;
            }
            else
            {
                // Otherwise, search the right half
                left = mid + 1;
            }
        }

        // At the end of the loop, left == right, and it is the peak index
        return left;
    }
}
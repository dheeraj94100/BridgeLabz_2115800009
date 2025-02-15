using System;

class FindRotationPoint
{
    public static int FindRotationIndex(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] > arr[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }
    static void Main(string[] args)
    {
        int[] rotatedArray = { 4, 5, 6, 7, 0, 1, 2 };
        int rotationIndex = FindRotationIndex(rotatedArray);
        Console.WriteLine("The index of the smallest element is: " + rotationIndex);
    }
}
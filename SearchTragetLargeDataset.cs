using System;
using System.Diagnostics;

class SearchTargetLargeDataset
{
    static void Main(string[] args)
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        Random random = new Random();

        foreach (int size in datasetSizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = random.Next(1, size * 10);
            }
            int target = data[size - 1];

            // Linear Search
            Stopwatch stopwatch = Stopwatch.StartNew();
            LinearSearch(data, target);
            stopwatch.Stop();
            Console.WriteLine($"Linear Search on dataset size {size}: {stopwatch.ElapsedMilliseconds} ms");

            // Binary Search
            Array.Sort(data);
            stopwatch.Restart();
            BinarySearch(data, target);
            stopwatch.Stop();
            Console.WriteLine($"Binary Search on dataset size {size}: {stopwatch.ElapsedMilliseconds} ms");
        }
    }

    static int LinearSearch(int[] data, int target)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static int BinarySearch(int[] data, int target)
    {
        int left = 0;
        int right = data.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (data[mid] == target)
            {
                return mid;
            }
            if (data[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}
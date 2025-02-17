using System;
using System.Diagnostics;

class SortLargeDataEfficiently
{
    static void Main(string[] args)
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        Random random = new Random();
        foreach(int size in datasetSizes)
        {
            int[] data = GenerateRandomArray(size);
            int[] bubbleSortData = (int[])data.Clone();
            int[] mergeSortData = (int[])data.Clone();
            int[] quickSortData = (int[])data.Clone();

            Console.WriteLine($"Sorting {size} elements:");

            // Bubble Sort
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubbleSort(bubbleSortData);
            stopwatch.Stop();
            Console.WriteLine($"Bubble Sort: {stopwatch.ElapsedMilliseconds}ms");

            // Merge Sort
            stopwatch.Restart();
            MergeSort(mergeSortData, 0, mergeSortData.Length - 1);
            stopwatch.Stop();
            Console.WriteLine($"Merge Sort: {stopwatch.ElapsedMilliseconds}ms");

            // Quick Sort
            stopwatch.Restart();
            QuickSort(quickSortData, 0, quickSortData.Length - 1);
            stopwatch.Stop();
            Console.WriteLine($"Quick Sort: {stopwatch.ElapsedMilliseconds}ms");
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(0, 1000000000);
        }
        return array;
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        Array.Copy(array, left, leftArray, 0, n1);
        Array.Copy(array, middle + 1, rightArray, 0, n2);

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(array, low, high);
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;
        return i + 1;
    }
}
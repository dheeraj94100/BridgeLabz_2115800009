using System;

class SortProductPrices
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] prices = new int[n];
        for(int i = 0; i < n; i++)
        {
            prices[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        QuickSort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted product prices in ascending order:");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
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
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
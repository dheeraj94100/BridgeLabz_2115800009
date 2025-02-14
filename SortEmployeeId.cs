using System;

class SortEmployeeId
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] employeeIds = new int[n];
        for(int i = 0; i < n; i++)
        {
            employeeIds[i] = Convert.ToInt32(Console.ReadLine());
        }

        InsertionSort(employeeIds);

        Console.WriteLine("Sorted Employee IDs:");
        foreach (int id in employeeIds)
        {
            Console.Write(id + " ");
        }
    }

    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
}
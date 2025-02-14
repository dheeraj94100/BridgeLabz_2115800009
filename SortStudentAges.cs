using System;

class SortStudentAges
{
    public static void CountingSort(int[] ages)
    {
        int maxAge = 18;
        int minAge = 10;
        int range = maxAge - minAge + 1;

        int[] count = new int[range];
        int[] output = new int[ages.Length];

        // Initialize count array with all zeros
        for (int i = 0; i < range; i++)
        {
            count[i] = 0;
        }

        // Store the count of each age
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        // Change count[i] so that count[i] now contains actual
        // position of this age in output array
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        // Build the output array
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        // Copy the sorted ages into original array
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] studentAges = new int[n];
        for(int i = 0; i < n; i++)
        {
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Original ages: " + string.Join(", ", studentAges));

        CountingSort(studentAges);

        Console.WriteLine("Sorted ages: " + string.Join(", ", studentAges));
    }
}
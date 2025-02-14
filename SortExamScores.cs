using System;

class SortExamScores
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] scores = new int[n];
        for(int i = 0; i < n; i++)
        {
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

        SelectionSort(scores);

        Console.WriteLine("Sorted exam scores:");
        foreach (int score in scores)
        {
            Console.Write(score + " ");
        }
    }

    static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}
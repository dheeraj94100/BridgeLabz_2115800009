using System;

class SortStudentMarks
{
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // Swap marks[j] and marks[j + 1]
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] studentMarks = new int[n];
        for(int i = 0; i < n; i++)
        {
            studentMarks[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Original Marks: " + string.Join(", ", studentMarks));

        BubbleSort(studentMarks);

        Console.WriteLine("Sorted Marks: " + string.Join(", ", studentMarks));
    }
}
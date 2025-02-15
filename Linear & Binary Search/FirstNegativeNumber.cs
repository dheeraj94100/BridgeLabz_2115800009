using System;

class FirstNegativeNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int firstNegative = FindFirstNegative(array);
        if (firstNegative != int.MaxValue)
        {
            Console.WriteLine("The first negative number in the array is: " + firstNegative);
        }
        else
        {
            Console.WriteLine("There are no negative numbers in the array.");
        }
    }

    static int FindFirstNegative(int[] array)
    {
        foreach (int num in array)
        {
            if (num < 0)
            {
                return num;
            }
        }
        return int.MaxValue; // Return a sentinel value if no negative number is found
    }
}
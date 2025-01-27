using System;

class ArrayAnalysis
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (IsPositive(numbers[i]))
            {
                Console.WriteLine(numbers[i] + " is positive and " + (IsEven(numbers[i]) ? "even." : "odd."));
            }
            else
            {
                Console.WriteLine(numbers[i] + " is negative.");
            }
        }

        Console.WriteLine("First and last elements comparison: " + Compare(numbers[0], numbers[^1]));
    }

    static bool IsPositive(int number)
    {
        return number >= 0;
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static string Compare(int num1, int num2)
    {
        if (num1 > num2) return "greater than";
        if (num1 < num2) return "less than";
        return "equal to";
    }
}

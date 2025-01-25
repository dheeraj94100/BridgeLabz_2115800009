using System;
class Program
{
    static void Main()
    {
        // Declare an array to store 5 numbers
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");

        // Take input for each number in the array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Check each number for positivity, negativity, zero, even, or odd
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                // Determine if the number is even or odd
                string evenOdd = (num % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{num} is positive and {evenOdd}.");
            }
            else if (num < 0)
            {
                // Negative number handling
                Console.WriteLine($"{num} is negative.");
            }
            else
            {
                // Zero handling
                Console.WriteLine($"{num} is zero.");
            }
        }

        // Compare the first and last elements of the array
        if (numbers[0] > numbers[^1])
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else if (numbers[0] < numbers[^1])
        {
            Console.WriteLine("The first number is less than the last number.");
        }
        else
        {
            Console.WriteLine("The first number is equal to the last number.");
        }
    }
}

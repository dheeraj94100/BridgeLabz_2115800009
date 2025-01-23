
using System;

class OddEvenNumbers
{
    static void Main(string[] args)
    {
        // Taking user input for the range limit
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a positive integer
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Iterate from 1 to the entered number
            for (int i = 1; i <= number; i++)
            {
                // Check if the current number is odd or even
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an Even number.");
                }
                else
                {
                    Console.WriteLine($"{i} is an Odd number.");
                }
            }
        }
    }
}


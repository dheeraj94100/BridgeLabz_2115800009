using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        // Prompt user for input
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a positive integer
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Loop from 0 to the entered number
            for (int i = 1; i <= number; i++)
            {
                // Check conditions for Fizz, Buzz, or FizzBuzz
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
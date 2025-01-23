
using System;

class FactorialCalculator
{
    static void Main(string[] args)
    {
        // Taking user input for the integer
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the user entered a positive integer
        if (number < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Initializing the factorial result variable to 1
            long factorial = 1;

            // Using a for loop to compute the factorial
            for (int i = 1; i <= number; i++)
            {
                factorial *= i; // Multiply the current factorial value by i
            }

            // Display the result
            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
    }
}


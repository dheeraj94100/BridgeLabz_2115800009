using System;

class NaturalNumberSum
{
    static void Main(string[] args)
    {
        // Taking input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Checking if the number is a natural number
        if (number > 0)
        {
            // Calculating the sum of first n natural numbers
            int sum = number * (number + 1) / 2;
            Console.WriteLine($"The sum of {number} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine($"The number {number} is not a natural number.");
        }
    }
}
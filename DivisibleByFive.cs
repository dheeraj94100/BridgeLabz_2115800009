using System;

class DivisibleByFive
{
    static void Main(string[] args)
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check divisibility by 5 using if-else
        if (number % 5 == 0)
        {
            Console.WriteLine($"Is the number {number} divisible by 5? Yes");
        }
        else
        {
            Console.WriteLine($"Is the number {number} divisible by 5? No");
        }
    }
}


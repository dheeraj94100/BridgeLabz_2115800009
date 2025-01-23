using System;

class FactorsOfNumber
{
    static void Main()
    {
        // Taking input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Finding and printing factors of the number
        Console.WriteLine($"Factors of {number}:");
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)  // Check if i is a factor
            {
                Console.Write(i + " ");
            }
        }
    }
}
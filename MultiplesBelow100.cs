using System;

class MultiplesBelow100
{
    static void Main()
    {
        // Taking input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Finding and printing multiples of the number below 100
        Console.WriteLine($"Multiples of {number} below 100:");
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)  // Check if i is a multiple of the number
            {
                Console.Write(i + " ");
            }
        }
    }
}
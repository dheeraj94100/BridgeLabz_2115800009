using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        // Prompt user for input
        Console.Write("Enter a positive integer to check if it is a prime number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Prime numbers are greater than 1
        if (number <= 1)
        {
            Console.WriteLine($"The number {number} is not a prime number.");
        }
        else
        {
            // Initialize the isPrime variable
            bool isPrime = true;

            // Loop from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                // Check if the number is divisible by i
                if (number % i == 0)
                {
                    isPrime = false; // Not a prime number
                    break;           // Exit the loop
                }
            }

            // Output the result based on the isPrime variable
            if (isPrime)
            {
                Console.WriteLine($"The number {number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"The number {number} is not a prime number.");
            }
        }
    }
}
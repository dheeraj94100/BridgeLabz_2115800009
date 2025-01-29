using System;

class PrimeNumberChecker
{
    static void Main()
    {
        // Get a number from the user to check
        int number = GetNumber("Enter a number to check if it's prime: ");

        if (IsPrime(number))
            Console.WriteLine($"{number} is a prime number.");
        else
            Console.WriteLine($"{number} is not a prime number.");
    }

   
    static int GetNumber(string prompt)
    {
        Console.Write(prompt); // Prompt user for input
        return Convert.ToInt32(Console.ReadLine()); // Convert input to integer
    }

    // Method to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1) return false; 

       
        for (int i = 2; i <= number/2; i++)
        {
            if (number % i == 0) // If divisible, not a prime
                return false;
        }

        return true; // If no divisors found, the number is prime
    }
}

using System;

class QuotientAndRemainder
{
    // Method to find the quotient and remainder of a number
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        // Initialize an array to store the quotient and remainder
        int[] result = new int[2];
        
        // Calculate the quotient using division operator
        int quotient = number / divisor;
        
        // Calculate the remainder using modulus operator
        int remainder = number % divisor;

        // Store the quotient and remainder in the result array
        result[0] = quotient;  // Quotient
        result[1] = remainder; // Remainder
        
        return result;
    }

    static void Main(string[] args)
    {
        // Input: Get two numbers from the user
        Console.Write("Enter the dividend (number): ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        // Check if divisor is 0 to avoid division by zero error
        if (divisor == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            // Call the method to find quotient and remainder
            int[] result = FindRemainderAndQuotient(number, divisor);

            // Output the quotient and remainder
            Console.WriteLine($"The quotient is: {result[0]}");
            Console.WriteLine($"The remainder is: {result[1]}");
        }
    }
}


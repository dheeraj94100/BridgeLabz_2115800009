using System;

class QuotientRemainder
{
    static void Main(string[] args)
    {
        // Prompt user to enter two numbers
        Console.WriteLine("Enter two numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        // Calculate quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Display results
        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
    }
}

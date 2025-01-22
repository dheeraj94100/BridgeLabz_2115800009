using System;

class QuotientRemainderCalculator
{
    static void Main(string[] args)
    {
        // Input: Taking two numbers from the user
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculate Quotient and Remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Display the result
        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
    }
}

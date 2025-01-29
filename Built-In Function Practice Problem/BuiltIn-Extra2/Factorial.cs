using System;

class FactorialUsingRecursion
{

    static void Main()
    {
       
        int number = GetNumber("Enter a number to calculate its factorial: ");
        
        Console.WriteLine($"The factorial of {number} is: {Factorial(number)}");
    }


    static int GetNumber(string prompt)
    {
        Console.Write(prompt); 
        return Convert.ToInt32(Console.ReadLine());     }

    // Method to calculate the factorial of a number using recursion
    static int Factorial(int n)
    {
        if (n == 0) return 1; // Base case: factorial of 0 is 1
        return n * Factorial(n - 1); // Recursive case
    }
}
using System;

class FibonacciSequenceGenerator
{
   
    static void Main()
    {
        // Get the number of terms from the user
        int terms = GetNumber("Enter the number of terms in the Fibonacci sequence: ");
        
       
        GenerateFibonacci(terms);
    }

   
    static int GetNumber(string prompt)
    {
        Console.Write(prompt); // Prompt user for input
        return Convert.ToInt32(Console.ReadLine()); // Convert input to integer
    }

    // Method to generate and display Fibonacci sequence
    static void GenerateFibonacci(int terms)
    {
        int first = 0, second = 1;

       
        for (int i = 0; i < terms; i++)
        {
            Console.Write(first + " ");
            int next = first + second; // Calculate next number
            first = second;
            second = next; 
        }
    }
}

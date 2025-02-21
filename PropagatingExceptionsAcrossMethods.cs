using System;

class Program
{
    static void Method1(int numerator, int denominator)
    {
        // Perform division and throw an exception if denominator is zero
        if (denominator == 0)
        {
            throw new ArithmeticException("Cannot divide by zero");
        }
        int result = numerator / denominator;
        Console.WriteLine($"Result: {result}");
    }

    static void Method2(int numerator, int denominator)
    {
        try
        {
            Method1(numerator, denominator); // Calls Method1, allowing exception to propagate
        }
        catch (ArithmeticException ex)
        {
            throw new ArithmeticException("Exception propagated from Method1", ex);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());
            
            Method2(numerator, denominator); // Calls Method2, which in turn calls Method1
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine("Handled exception in Main: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integers.");
        }
    }
}

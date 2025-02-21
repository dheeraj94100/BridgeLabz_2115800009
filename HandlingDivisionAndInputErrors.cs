using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the numerator: ");
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the denominator: ");
            double denominator = Convert.ToDouble(Console.ReadLine());

            if (denominator == 0)
                throw new DivideByZeroException();

            double result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integers.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}

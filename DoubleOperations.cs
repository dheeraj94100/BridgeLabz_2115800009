using System;

class DoubleOperations
{
    static void Main(string[] args)
    {
        // Prompt user to enter three double values
        Console.WriteLine("Enter three double values a, b, and c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        // Perform various double operations and display results
        Console.WriteLine($"Results: {a + b * c}, {a * b + c}, {c + a / b}");
    }
}

using System;

class IntOperations
{
    static void Main(string[] args)
    {
        // Prompt user to enter three integers
        Console.WriteLine("Enter three integers a, b, and c:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        // Perform various integer operations and display results
        Console.WriteLine($"Results: {a + b * c}, {a * b + c}, {c + a / b}, {a % b + c}");
    }
}

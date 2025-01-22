using System;

class DoubleOpt
{
    static void Main(string[] args)
    {
        // Input: Taking a, b, and c as input values (double type)
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Compute operations
        double result1 = a + b * c;        // Multiplication (*) has higher precedence than addition (+)
        double result2 = a * b + c;        // Multiplication (*) is evaluated before addition (+)
        double result3 = c + a / b;        // Division (/) is evaluated before addition (+)
        double result4 = a % b + c;        // Modulus (%) is evaluated before addition (+)

        // Output: Display the results
        Console.WriteLine($"The results of Double Operations are:");
        Console.WriteLine($"1. a + b * c = {result1}");
        Console.WriteLine($"2. a * b + c = {result2}");
        Console.WriteLine($"3. c + a / b = {result3}");
        Console.WriteLine($"4. a % b + c = {result4}");
    }
}

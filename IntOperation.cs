using System;

class IntOperation
{
    static void Main(string[] args)
    {
        // Input: Taking a, b, and c as input values
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Compute integer operations
        int result1 = a + b * c;          // Multiplication (*) has higher precedence than addition (+)
        int result2 = a * b + c;          // Multiplication (*) is evaluated before addition (+)
        int result3 = c + a / b;          // Division (/) is evaluated before addition (+)
        int result4 = a % b + c;          // Modulus (%) is evaluated before addition (+)

        // Output: Display the results
        Console.WriteLine($"The results of Int Operations are:");
        Console.WriteLine($"1. a + b * c = {result1}");
        Console.WriteLine($"2. a * b + c = {result2}");
        Console.WriteLine($"3. c + a / b = {result3}");
        Console.WriteLine($"4. a % b + c = {result4}");
    }
}

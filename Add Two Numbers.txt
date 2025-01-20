using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        
        double sum = num1 + num2;

      
        Console.WriteLine("The sum of numbers is "+ sum);
    }
}
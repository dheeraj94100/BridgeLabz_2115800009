using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        // Prompt user for Principal, Rate, and Time
        Console.WriteLine("Enter the Principal amount:");
        double principal = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Rate of Interest (in %):");
        double rate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Time (in years):");
        double time = double.Parse(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Display the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}, and Time {time}");
    }
}


using System;

class SimpleInterestCalculator
{
    static void Main(string[] args)
    {
        // Take user input for Principal, Rate, and Time
        Console.Write("Enter Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = CalculateSimpleInterest(principal, rate, time);

        // Display the result
        Console.WriteLine($"The Simple Interest is {simpleInterest:F2} for Principal {principal}, Rate of Interest {rate}, and Time {time}.");
    }

    // Method to calculate Simple Interest
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}


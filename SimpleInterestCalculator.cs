using System;

class SimpleInterestCalculator
{
    static void Main(string[] args)
    {
        // Taking user input for Principal, Rate, and Time
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculating the Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Displaying the results
        Console.WriteLine($"\nThe Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}, and Time {time} years.");
    }
}

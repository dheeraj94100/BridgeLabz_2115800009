using System;

class WeightConverter
{
    static void Main(string[] args)
    {
        // Prompt user to enter weight in pounds
        Console.WriteLine("Enter the weight (in pounds):");
        double weightInPounds = double.Parse(Console.ReadLine());

        // Convert weight to kilograms
        double weightInKg = weightInPounds / 2.2;

        // Display the results
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kilograms is {weightInKg:F2}");
    }
}

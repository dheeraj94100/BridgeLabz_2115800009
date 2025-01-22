using System;

class WeightConversion
{
    static void Main(string[] args)
    {
        // Taking user input for weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Conversion factor from pounds to kilograms
        double conversionFactor = 2.2;

        // Converting weight from pounds to kilograms
        double weightInKilograms = weightInPounds / conversionFactor;

        // Displaying the results
        Console.WriteLine($"\nThe weight of the person in pounds is {weightInPounds} and in kilograms is {weightInKilograms:F2}.");
    }
}

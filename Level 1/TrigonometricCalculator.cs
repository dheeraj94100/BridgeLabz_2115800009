using System;

class TrigonometricCalculator
{
    // Method to calculate trigonometric functions: sine, cosine, and tangent
    public double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert the angle from degrees to radians
        double radians = (Math.PI * angle) / 180.0;

        // Calculate the sine, cosine, and tangent of the angle
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the results as an array
        return new double[] { sine, cosine, tangent };
    }

    static void Main(string[] args)
    {
        // Create an instance of TrigonometricCalculator
        TrigonometricCalculator calculator = new TrigonometricCalculator();

        // Get user input for the angle in degrees
        Console.Write("Enter an angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Calculate the trigonometric functions using the method
        double[] results = calculator.CalculateTrigonometricFunctions(angle);

        // Output the results: sine, cosine, and tangent
        Console.WriteLine($"Sine of {angle}°: {results[0]:F4}");
        Console.WriteLine($"Cosine of {angle}°: {results[1]:F4}");
        Console.WriteLine($"Tangent of {angle}°: {results[2]:F4}");
    }
}
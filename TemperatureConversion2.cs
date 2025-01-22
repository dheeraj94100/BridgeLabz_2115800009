using System;

class TemperatureConversion
{
    static void Main(string[] args)
    {
        // Input: Taking the temperature in Fahrenheit from the user
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Conversion: Fahrenheit to Celsius
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Output: Display the result
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius.");
    }
}

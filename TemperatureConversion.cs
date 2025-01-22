using System;

class TemperatureConversion
{
    static void Main(string[] args)
    {
        // Input: Taking the temperature in Celsius from the user
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Conversion: Celsius to Fahrenheit
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Output: Display the result
        Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit.");
    }
}

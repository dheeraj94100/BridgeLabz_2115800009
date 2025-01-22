using System;

class CelsiusToFahrenheit
{
    static void Main(string[] args)
    {
        // Prompt user to enter temperature in Celsius
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine());

        // Convert Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Display the result
        Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");
    }
}

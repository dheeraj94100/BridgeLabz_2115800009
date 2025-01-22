using System;

class FahrenheitToCelsius
{
    static void Main(string[] args)
    {
        // Prompt user to enter temperature in Fahrenheit
        Console.WriteLine("Enter temperature in Fahrenheit:");
        double fahrenheit = double.Parse(Console.ReadLine());

        // Convert Fahrenheit to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Display the result
        Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius} Celsius");
    }
}

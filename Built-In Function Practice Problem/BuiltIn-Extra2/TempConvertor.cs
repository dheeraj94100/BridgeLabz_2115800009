using System;

class TemperatureConverter
{
        static void Main()
    {
       
        double fahrenheit = GetTemperature("Enter temperature in Fahrenheit: ");
        double celsius = ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C");

        celsius = GetTemperature("Enter temperature in Celsius: ");
        fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
    }

    // Method to get a temperature value from the user
    static double GetTemperature(string prompt)
    {
        Console.Write(prompt); // Prompt user for input
        return Convert.ToDouble(Console.ReadLine()); // Convert input to double
    }

    // Method to convert Fahrenheit to Celsius
    static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9; // Formula to convert Fahrenheit to Celsius
    }

    // Method to convert Celsius to Fahrenheit
    static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32; // Formula to convert Celsius to Fahrenheit
    }
}

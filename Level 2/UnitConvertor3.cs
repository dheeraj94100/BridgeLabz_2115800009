using System;

class UnitConverter
{
    static void Main()
    {
        Console.WriteLine("Enter Fahrenheit to convert to Celsius:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Celsius: " + ConvertFahrenheitToCelsius(fahrenheit));

        Console.WriteLine("Enter Celsius to convert to Fahrenheit:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Fahrenheit: " + ConvertCelsiusToFahrenheit(celsius));
    }

    static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}

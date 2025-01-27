using System;

class WindChillCalculator
{
    // Method to calculate the wind chill temperature
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        // Applying the wind chill formula
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }

    static void Main(string[] args)
    {
        // Create an instance of WindChillCalculator class
        WindChillCalculator calculator = new WindChillCalculator();

        // Taking user inputs for temperature and wind speed
        Console.Write("Enter the temperature in Fahrenheit: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the wind speed in miles per hour: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        // Validate inputs to ensure wind speed is positive
        if (windSpeed < 0)
        {
            Console.WriteLine("Wind speed must be a non-negative value.");
        }
        else
        {
            // Calculate wind chill using the method
            double windChill = calculator.CalculateWindChill(temperature, windSpeed);

            // Output the result
            Console.WriteLine($"The wind chill temperature is: {windChill:F2}°F");
        }
    }
}


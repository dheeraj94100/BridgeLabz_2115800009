using System;

class UnitConverter
{
    static void Main()
    {
        Console.WriteLine("Enter kilometers to convert to miles:");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Miles: " + ConvertKmToMiles(km));

        Console.WriteLine("Enter miles to convert to kilometers:");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Kilometers: " + ConvertMilesToKm(miles));
    }

    static double ConvertKmToMiles(double km)
    {
        return km * 0.621371;
    }

    static double ConvertMilesToKm(double miles)
    {
        return miles * 1.60934;
    }
}

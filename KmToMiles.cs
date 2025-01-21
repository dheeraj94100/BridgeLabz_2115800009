using System;

class DistanceConverter
{
    static void Main(string[] args)
    {
        double distanceInKilometers = 10.8;
        double conversionFactor = 1.6;

        double distanceInMiles = distanceInKilometers / conversionFactor;
        Console.WriteLine($"The distance {distanceInKilometers} km in miles is {distanceInMiles:F2}.");
    }
}

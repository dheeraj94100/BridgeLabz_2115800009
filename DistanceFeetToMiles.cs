using System;

class FeetToMiles {
    static void Main() {
        Console.WriteLine("Enter the distance in feet:");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());
        
        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;
        
        Console.WriteLine($"The distance is {distanceInYards:F2} yards and {distanceInMiles:F2} miles for the distance of {distanceInFeet} feet.");
    }
}
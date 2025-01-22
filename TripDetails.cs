using System;

class TravelProgram
{
    static void Main(string[] args)
    {
        // Prompt user for traveler details
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        // Prompt user for travel details
        Console.WriteLine("Enter From City:");
        string fromCity = Console.ReadLine();
        Console.WriteLine("Enter Via City:");
        string viaCity = Console.ReadLine();
        Console.WriteLine("Enter To City:");
        string toCity = Console.ReadLine();

        // Prompt user for distances and time
        Console.WriteLine("Enter distance from From City to Via City (in miles):");
        double fromToVia = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter distance from Via City to Final City (in miles):");
        double viaToFinalCity = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter total time taken for the journey (in hours):");
        double timeTaken = double.Parse(Console.ReadLine());

        // Calculate total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Display the travel summary
        Console.WriteLine($"The traveler {name} started from {fromCity}, traveled via {viaCity}, and reached {toCity}. Total distance: {totalDistance} miles. Average speed: {averageSpeed} mph.");
    }
}

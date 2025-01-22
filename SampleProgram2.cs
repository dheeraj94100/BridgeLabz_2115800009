using System;

class SampleProgram2
{
    static void Main(string[] args)
    {
        // Taking user inputs
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter the distance from the starting city to the via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from the via city to the destination city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the total time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculating total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Outputting the results
        Console.WriteLine("\nThe results of the trip are:");
        Console.WriteLine($"Traveler: {name}");
        Console.WriteLine($"Route: {fromCity} -> {viaCity} -> {toCity}");
        Console.WriteLine($"Total Distance: {totalDistance} miles");
        Console.WriteLine($"Average Speed: {averageSpeed:F2} miles/hour");
    }
}

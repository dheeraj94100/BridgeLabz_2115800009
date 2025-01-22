using System;

class AthleteRounds
{
    static void Main(string[] args)
    {
        // Prompt user to enter the sides of the triangular park
        Console.WriteLine("Enter the lengths of the three sides of the triangular park (in meters):");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        // Calculate the perimeter of the park
        double perimeter = side1 + side2 + side3;

        // Define total distance the athlete needs to run (5 km in meters)
        double totalDistance = 5000;

        // Calculate the number of rounds required
        int rounds = (int)Math.Ceiling(totalDistance / perimeter);

        // Display the number of rounds
        Console.WriteLine($"The athlete must complete {rounds} rounds to cover 5 km.");
    }
}

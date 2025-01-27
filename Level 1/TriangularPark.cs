
using System;

class TriangularPark
{
    // Method to compute the number of rounds
    static double CalculateRounds(double side1, double side2, double side3, double distance)
    {
        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds
        return distance / perimeter;
    }

    static void Main(string[] args)
    {
        // Prompt user for the lengths of the three sides of the triangular park
        Console.WriteLine("Enter the length of side 1 (in meters):");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2 (in meters):");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3 (in meters):");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Define the total distance to be run (5 km = 5000 meters)
        double distance = 5000;

        // Calculate the number of rounds
        double rounds = CalculateRounds(side1, side2, side3, distance);

        // Display the result
        Console.WriteLine($"The athlete needs to complete approximately {Math.Ceiling(rounds)} rounds to run 5 kilometers.");
    }
}


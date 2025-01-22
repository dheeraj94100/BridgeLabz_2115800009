using System;

class TriangularParkRun
{
    static void Main(string[] args)
    {
        // Taking user inputs for the sides of the triangular park
        Console.Write("Enter the first side of the triangular park (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangular park (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangular park (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculating the perimeter of the triangular park
        double perimeter = side1 + side2 + side3;

        // Converting 5 km to meters (1 km = 1000 meters)
        double totalDistance = 5 * 1000;

        // Calculating the total number of rounds needed
        double rounds = totalDistance / perimeter;

        // Outputting the result
        Console.WriteLine($"\nThe total number of rounds the athlete will run is {Math.Ceiling(rounds)} to complete 5 km.");
    }
}

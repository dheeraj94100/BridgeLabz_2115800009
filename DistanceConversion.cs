using System;

class DistanceConversion {
    static void Main() {
        Console.WriteLine("Enter the distance in kilometers:");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers / 1.6;

        Console.WriteLine($"The total miles is {miles:F2} mile for the given {kilometers} km.");
    }
}
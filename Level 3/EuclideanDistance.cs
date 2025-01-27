using System;

class EuclideanDistance
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean Distance: {distance}");

        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"Equation of the line: y = {lineEquation[0]}x + {lineEquation[1]}");
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);
        double yIntercept = y1 - slope * x1;
        return new double[] { slope, yIntercept };
    }
}
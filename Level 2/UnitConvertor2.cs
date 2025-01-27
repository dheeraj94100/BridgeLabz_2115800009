using System;

class UnitConverter
{
    static void Main()
    {
        Console.WriteLine("Enter yards to convert to feet:");
        double yards = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Feet: " + ConvertYardsToFeet(yards));

        Console.WriteLine("Enter feet to convert to yards:");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yards: " + ConvertFeetToYards(feet));
    }

    static double ConvertYardsToFeet(double yards)
    {
        return yards * 3;
    }

    static double ConvertFeetToYards(double feet)
    {
        return feet * 0.333333;
    }
}

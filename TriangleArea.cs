using System;

class TriangleArea {
    static void Main() {
        Console.WriteLine("Enter the base of the triangle (in inches):");
        double baseInInches = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the triangle (in inches):");
        double heightInInches = Convert.ToDouble(Console.ReadLine());
        
        double areaInSquareInches = 0.5 * baseInInches * heightInInches;
        double areaInSquareCm = areaInSquareInches * 6.4516;
        
        Console.WriteLine($"The area of the triangle is {areaInSquareInches:F2} square inches and {areaInSquareCm:F2} square centimeters.");
    }
}
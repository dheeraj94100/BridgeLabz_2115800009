using System;

class HeightConversion {
    static void Main() {
        Console.WriteLine("Enter your height in centimeters:");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        
        double heightInInches = heightCm / 2.54;
        int feet = (int)heightInInches / 12;
        double inches = heightInInches % 12;

        Console.WriteLine($"Your Height in cm is {heightCm:F2} while in feet is {feet} and inches is {inches:F2}.");
    }
}
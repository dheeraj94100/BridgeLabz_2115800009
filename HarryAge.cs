using System;

class AgeCalculator
{
    static void Main(string[] args)
    {
      
        int birthYear = 2000;
        int currentYear = 2024;

        
        int age = currentYear - birthYear;

        
        Console.WriteLine($"Harry's age in {currentYear} is {age}.");
    }
}
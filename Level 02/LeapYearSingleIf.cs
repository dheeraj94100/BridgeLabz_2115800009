using System;

class LeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year (>= 1582): ");
        int year = Convert.ToInt32(Console.ReadLine()); // Read input

        // Ensure the year is within the Gregorian calendar range
        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or later to check for a leap year.");
            return;
        }

        // Single if condition to determine Leap Year
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a Leap Year.");
        }
        else
        {
            Console.WriteLine($"{year} is Not a Leap Year.");
        }
    }
}
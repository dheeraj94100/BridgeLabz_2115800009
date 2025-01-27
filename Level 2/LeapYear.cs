using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Year is not in the Gregorian calendar.");
            return;
        }

        bool isLeap = CheckLeapYear(year);
        Console.WriteLine(year + " is " + (isLeap ? "a Leap Year." : "not a Leap Year."));
    }

    static bool CheckLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}

using System;

class DateArithmeticProgram
{
    static void Main()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = Convert.ToDateTime(Console.ReadLine());

        // Adding 7 days, 1 month, and 2 years
        DateTime newDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);

        // Subtracting 3 weeks (21 days)
        newDate = newDate.AddDays(1);

        Console.WriteLine($"Updated Date: {newDate:yyyy-MM-dd}");
    }
}
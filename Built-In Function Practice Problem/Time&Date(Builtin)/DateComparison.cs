using System;

class DateComparisonProgram
{
    static void Main()
    {
        // Taking two date inputs
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        DateTime firstDate = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter the second date (yyyy-MM-dd): ");
        DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

        // Comparing using DateTime.Compare()
        int result = DateTime.Compare(firstDate, secondDate);
        if (result < 0)
        {
            Console.WriteLine("The first date is before the second date.");
        }
        else if (result > 0)
        {
            Console.WriteLine("The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("The first date is the same as the second date.");
        }

        // Comparing using CompareTo()
        if (firstDate.CompareTo(secondDate) < 0)
        {
            Console.WriteLine("Using CompareTo(): The first date is before the second date.");
        }
        else if (firstDate.CompareTo(secondDate) > 0)
        {
            Console.WriteLine("Using CompareTo(): The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("Using CompareTo(): The first date is the same as the second date.");
        }

        // Direct comparison using equality and relational operators
        if (firstDate < secondDate)
        {
            Console.WriteLine("Using direct comparison: The first date is before the second date.");
        }
        else if (firstDate > secondDate)
        {
            Console.WriteLine("Using direct comparison: The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("Using direct comparison: The first date is the same as the second date.");
        }
    }
}

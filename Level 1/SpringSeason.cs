using System;

class SpringSeason
{
    // Method to check if the given date is in the Spring season
    static bool IsSpringSeason(int month, int day)
    {
        // Check if the month and day fall within Spring Season (March 20 to June 20)
        if ((month == 3 && day >= 20 && day <= 31) || // March 20 to March 31
            (month == 4 && day >= 1 && day <= 30) ||  // April 1 to April 30
            (month == 5 && day >= 1 && day <= 31) ||  // May 1 to May 31
            (month == 6 && day >= 1 && day <= 20))    // June 1 to June 20
        {
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        // Input: month and day
        Console.WriteLine("Enter the month (1 for January, 2 for February, etc.):");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the day:");
        int day = Convert.ToInt32(Console.ReadLine());

        // Validate input
        if (month < 1 || month > 12 || day < 1 || day > 31)
        {
            Console.WriteLine("Invalid date input.");
            return;
        }

        // Check if it's Spring Season
        if (IsSpringSeason(month, day))
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}


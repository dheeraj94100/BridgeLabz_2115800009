
using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        // Taking month and day input from the user
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter day (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());

        // Checking if the date falls within the Spring Season (March 20 to June 20)
        if ((month == 3 && day >= 20) || 
            (month == 4) || 
            (month == 5) || 
            (month == 6 && day <= 20))
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}


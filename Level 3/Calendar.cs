using System;

class Calendar
{
    static void Main(string[] args)
    {
        int month = Convert.ToInt32(Console.ReadLine());
        int year = Convert.ToInt32(Console.ReadLine());
        int d0 = GetFirstDay(month, year);
        Display(d0, month, year);
    }
    static string GetMonth(int month)
    {
        string[] monthName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        return monthName[month - 1];
    }
    static int GetDays(int month, int year)
    {
        int[] numberOfDays = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        if(IsLeapYear(year))
        {
            numberOfDays[1] = 29;
        }
        return numberOfDays[month - 1];
    }
    static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    }

    static int GetFirstDay(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7;
        return d0;
    }
    static void Display(int day, int month, int year)
    {
        string monthName = GetMonth(month);
        int days = GetDays(month, year);
        Console.WriteLine("{0} {1}", monthName, year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        for(int i = 0; i < day; i++)
        {
            Console.Write("    ");
        }
        for(int i = 1; i <= days; i++)
        {
            Console.Write(" {0, 2} ", i);
            if((i + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
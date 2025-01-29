using System;

class DateArithmeticProgram
{
    static void Main()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = Convert.ToDateTime(Console.ReadLine());

        // Display the date in 'yyyy-MM-dd' format
        Console.WriteLine("Updated Date (yyyy-MM-dd): " + inputDate.ToString("yyyy-MM-dd"));

        // Display the date in 'dd/MM/yyyy' format using .ToString()
        Console.WriteLine("Updated Date (dd/MM/yyyy): " + inputDate.ToString("dd/MM/yyyy"));
        
        Console.WriteLine("Updated Date (EEE, MMM dd, yyyy): "+ inputDate.ToString("ddd, MMM dd, yyyy"));
        
        
    }
}
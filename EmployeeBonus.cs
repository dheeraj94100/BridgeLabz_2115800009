
using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        // Taking user input for salary and years of service
        Console.Write("Enter the employee's salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the number of years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        // Define the bonus percentage
        double bonusPercentage = 0.05;  // 5% bonus for employees with more than 5 years of service

        // Calculate and print the bonus
        if (yearsOfService > 5)
        {
            double bonus = salary * bonusPercentage;
            Console.WriteLine($"The employee is eligible for a bonus of INR {bonus:F2}");
        }
        else
        {
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}


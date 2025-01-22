using System;

class TotalIncome
{
    static void Main(string[] args)
    {
        // Prompt user to enter salary and bonus
        Console.WriteLine("Enter salary:");
        double salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter bonus:");
        double bonus = double.Parse(Console.ReadLine());

        // Calculate total income
        double totalIncome = salary + bonus;

        // Display the result
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
    }
}

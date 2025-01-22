using System;

class TotalIncomeCalculator
{
    static void Main(string[] args)
    {
        // Input: Taking salary and bonus from the user
        Console.Write("Enter your salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculation: Total income
        double totalIncome = salary + bonus;

        // Output: Display the salary, bonus, and total income
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}.");
    }
}

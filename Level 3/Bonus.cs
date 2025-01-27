using System;

class Bonus
{
    static void Main(string[] args)
    {
        int[,] employeeData = GenerateEmployeeData(10);
        int[,] updatedEmployeeData = CalculateNewSalaryAndBonus(employeeData);
        DisplaySummary(employeeData, updatedEmployeeData);
    }

    static int[,] GenerateEmployeeData(int numberOfEmployees)
    {
        Random random = new Random();
        int[,] data = new int[numberOfEmployees, 2];

        for (int i = 0; i < numberOfEmployees; i++)
        {
            data[i, 0] = random.Next(10000, 100000); // Random 5-digit salary
            data[i, 1] = random.Next(1, 11); // Random years of service between 1 and 10
        }

        return data;
    }

    static int[,] CalculateNewSalaryAndBonus(int[,] employeeData)
    {
        int numberOfEmployees = employeeData.GetLength(0);
        int[,] updatedData = new int[numberOfEmployees, 2];

        for (int i = 0; i < numberOfEmployees; i++)
        {
            int salary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];
            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
            int bonus = (int)(salary * bonusPercentage);
            int newSalary = salary + bonus;

            updatedData[i, 0] = newSalary;
            updatedData[i, 1] = bonus;
        }

        return updatedData;
    }

    static void DisplaySummary(int[,] oldData, int[,] newData)
    {
        int numberOfEmployees = oldData.GetLength(0);
        int totalOldSalary = 0;
        int totalNewSalary = 0;
        int totalBonus = 0;

        Console.WriteLine("Employee\tOld Salary\tYears of Service\tNew Salary\tBonus");
        for (int i = 0; i < numberOfEmployees; i++)
        {
            int oldSalary = oldData[i, 0];
            int yearsOfService = oldData[i, 1];
            int newSalary = newData[i, 0];
            int bonus = newData[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;
            // Display employee data with the help of google and stackoverflow.
            Console.WriteLine($"{i + 1}\t\t{oldSalary}\t\t{yearsOfService}\t\t\t{newSalary}\t\t{bonus}");
        }

        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
        Console.WriteLine($"Total Bonus Amount: {totalBonus}");
    }
}
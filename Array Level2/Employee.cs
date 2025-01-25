using System;
class EmployeeBonusCalculation {
    static void Main() {
        double[,] employeeData = new double[10, 4];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"Enter salary and years of service for Employee {i + 1}:");

            // Input salary and years of service
            double salary = Convert.ToDouble(Console.ReadLine());
            double yearsOfService = Convert.ToDouble(Console.ReadLine());

            if (salary <= 0 || yearsOfService < 0) {
                Console.WriteLine("Invalid input. Please enter valid salary and years of service.");
                i--;
                continue;
            }

            double bonus = (yearsOfService > 5) ? 0.05 * salary : 0.02 * salary;
            double newSalary = salary + bonus;

            employeeData[i, 0] = salary;
            employeeData[i, 1] = yearsOfService;
            employeeData[i, 2] = bonus;
            employeeData[i, 3] = newSalary;

            totalBonus += bonus;
            totalOldSalary += salary;
            totalNewSalary += newSalary;
        }

        Console.WriteLine($"Total Bonus Payout: {totalBonus:F2}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:F2}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:F2}");
    }
}

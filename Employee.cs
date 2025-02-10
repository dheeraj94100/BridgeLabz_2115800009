using System;
using System.Collections.Generic;

// Abstract class Employee
abstract class Employee
{
    // Private fields (Encapsulation)
    private int employeeId;
    private string name;
    private double baseSalary;

    // Constructor to initialize employee details
    public Employee(int id, string name, double salary)
    {
        this.employeeId = id;
        this.name = name;
        this.baseSalary = salary;
    }

    // Properties to access private fields
    public int EmployeeId { get { return employeeId; } }
    public string Name { get { return name; } }
    public double BaseSalary { get { return baseSalary; } }

    // Abstract method for calculating salary (to be implemented in subclasses)
    public abstract double CalculateSalary();

    // Concrete method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Base Salary: {BaseSalary:C}, Final Salary: {CalculateSalary():C}");
    }
}

// Interface for department-related functionality
interface IDepartment
{
    void AssignDepartment(string dept);
    string GetDepartmentDetails();
}

// Full-time employee class
class FullTimeEmployee : Employee, IDepartment
{
    private string department;
    private double fixedSalary;

    public FullTimeEmployee(int id, string name, double baseSalary, double fixedSalary)
        : base(id, name, baseSalary)
    {
        this.fixedSalary = fixedSalary;
    }

    // Implement CalculateSalary method
    public override double CalculateSalary()
    {
        return BaseSalary + fixedSalary;
    }

    // Implement IDepartment methods
    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

// Part-time employee class
class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int workHours;
    private double hourlyRate;

    public PartTimeEmployee(int id, string name, double baseSalary, int workHours, double hourlyRate)
        : base(id, name, baseSalary)
    {
        this.workHours = workHours;
        this.hourlyRate = hourlyRate;
    }

    // Implement CalculateSalary method
    public override double CalculateSalary()
    {
        return BaseSalary + (workHours * hourlyRate);
    }

    // Implement IDepartment methods
    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter number of employees: ");
        int numEmployees = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine("\nEnter details for Employee " + (i + 1));
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Base Salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Employee Type (f for FullTime/p for PartTime): ");
            string type = Console.ReadLine().ToLower();

            if (type == "f")
            {
                Console.Write("Enter Fixed Salary: ");
                double fixedSalary = Convert.ToDouble(Console.ReadLine());

                FullTimeEmployee emp = new FullTimeEmployee(id, name, baseSalary, fixedSalary);
                Console.Write("Enter Department: ");
                emp.AssignDepartment(Console.ReadLine());
                employees.Add(emp);
            }
            else if (type == "p")
            {
                Console.Write("Enter Work Hours: ");
                int workHours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Hourly Rate: ");
                double hourlyRate = Convert.ToDouble(Console.ReadLine());

                PartTimeEmployee emp = new PartTimeEmployee(id, name, baseSalary, workHours, hourlyRate);
                Console.Write("Enter Department: ");
                emp.AssignDepartment(Console.ReadLine());
                employees.Add(emp);
            }
            else
            {
                Console.WriteLine("Invalid Employee Type. Skipping entry.");
            }
        }

        Console.WriteLine("\nEmployee Details:");
        foreach (var emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}

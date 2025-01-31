using System;

class Employee
{
    private string name;
    private int id;
    private double salary;

    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + salary);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp = new Employee(name, id, salary);
        emp.DisplayDetails();
    }
}
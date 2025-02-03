using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Employee
    {
        public int EmployeeID { get; set; }  // Public: Accessible everywhere
        protected string Department { get; set; }  // Protected: Accessible in derived classes
        private double Salary;  // Private: Only accessible within the class

        // Constructor
        public Employee(int employeeID, string department, double salary)
        {
            EmployeeID = employeeID;
            Department = department;
            Salary = salary;
        }

        // Public method to modify salary
        public void SetSalary(double newSalary)
        {
            if (newSalary > 0)
            {
                Salary = newSalary;
                Console.WriteLine($"New Salary: {Salary}");
            }
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Department: {Department}, Salary: {Salary}");
        }
    }

    // Subclass demonstrating protected access
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(int employeeID, string department, double salary, int teamSize)
            : base(employeeID, department, salary)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerDetails()
        {
            Console.WriteLine($"Manager ID: {EmployeeID}, Department: {Department}, Team Size: {TeamSize}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee(101, "IT", 60000);
            emp.SetSalary(65000);
            emp.DisplayEmployeeDetails();

            Manager mgr = new Manager(201, "HR", 90000, 10);
            mgr.DisplayManagerDetails();
=======

class Employee
{
    private static string CompanyName = "Tech Solutions"; // Static variable shared by all employees
    private static int totalEmployees = 0; // Counter for the total number of employees

    public readonly int Id;  // Readonly variable for employee ID (cannot be changed after assignment)
    public string Name;
    public string Designation;

    // Constructor using 'this' to initialize Name, Id, and Designation
    public Employee(string name, string designation)
    {
        this.Id = new Random().Next(1000, 9999); // Generate a unique ID for each employee
        this.Name = name;
        this.Designation = designation;
        totalEmployees++; // Increment total employees count
    }

    // Static method to display the total number of employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total Employees in {CompanyName}: {totalEmployees}");
    }

    // Method to display employee details using the 'is' operator for type checking
    public void DisplayEmployeeDetails()
    {
        if (this is Employee)  // Check if the object is an instance of Employee
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
        }
        else
        {
            Console.WriteLine("Invalid employee record!");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int employeeCount = Convert.ToInt32(Console.ReadLine());

        Employee[] employees = new Employee[employeeCount];

        // Creating employees
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine($"\nEnter details for Employee {i + 1}:");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Designation: ");
            string designation = Console.ReadLine();

            employees[i] = new Employee(name, designation); // Initialize employee object
        }

        // Display total employees in the company
        Employee.DisplayTotalEmployees();

        // Display details of all employees
        Console.WriteLine("\nEmployee Details:");
        foreach (Employee employee in employees)
        {
            employee.DisplayEmployeeDetails(); // Display details for each employee
>>>>>>> 32cfaf8c574052612043f6bc65b30cba3343b263
        }
    }
}

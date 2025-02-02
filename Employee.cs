using System;
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
        }
    }
}

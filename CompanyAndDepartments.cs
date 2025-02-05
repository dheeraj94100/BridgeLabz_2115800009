using System;
using System.Collections.Generic;

namespace BridgeLabz
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }

    public class Company : IDisposable
    {
        public string CompanyName { get; set; }
        public List<Department> Departments { get; set; }

        public Company(string companyName)
        {
            CompanyName = companyName;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void Dispose()
        {
            // Dispose of all departments and employees
            foreach (var department in Departments)
            {
                department.Employees.Clear();
            }
            Departments.Clear();
            Console.WriteLine("Company and all its departments and employees have been deleted.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("TechCorp");

            Department hr = new Department("HR");
            hr.AddEmployee(new Employee("Alice", 1));
            hr.AddEmployee(new Employee("Bob", 2));

            Department it = new Department("IT");
            it.AddEmployee(new Employee("Charlie", 3));
            it.AddEmployee(new Employee("Dave", 4));

            company.AddDepartment(hr);
            company.AddDepartment(it);

            // Dispose of the company and all its departments and employees
            company.Dispose();
        }
    }
}
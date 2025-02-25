using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SortCSVRecordsByColumn
{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";

        try
        {
            var lines = File.ReadAllLines(filePath);
            var employees = new List<Employee>();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                employees.Add(new Employee
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Department = values[2],
                    Salary = decimal.Parse(values[3])
                });
            }

            var sortedEmployees = employees.OrderByDescending(e => e.Salary).Take(5);

            Console.WriteLine("Top 5 highest-paid employees:");
            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine(employee.ID + "," + employee.Name + "," + employee.Department + "," + employee.Salary);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: {ex.Message}");
        }
    }
}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}
using System;
using System.Collections.Generic;
using System.IO;

class WriteDataToCSV
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "John Doe", Department = "HR", Salary = 50000 },
            new Employee { ID = 2, Name = "Jane Smith", Department = "IT", Salary = 60000 },
            new Employee { ID = 3, Name = "Sam Brown", Department = "Finance", Salary = 55000 },
            new Employee { ID = 4, Name = "Lisa White", Department = "Marketing", Salary = 52000 },
            new Employee { ID = 5, Name = "Tom Clark", Department = "Sales", Salary = 58000 }
        };

        string filePath = "employees.csv";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Department,Salary");
                foreach (var employee in employees)
                {
                    writer.WriteLine($"{employee.ID},{employee.Name},{employee.Department},{employee.Salary}");
                }
            }
            Console.WriteLine("Data written to CSV file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: {ex.Message}");
        }
    }
}
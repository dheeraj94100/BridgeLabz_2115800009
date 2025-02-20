using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

[Serializable]
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

public class SerializationDemo
{
    private const string FilePath = "employees.json";

    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Console.WriteLine("Enter the number of employees you want to add:");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfEmployees; i++)
        {
            Employee employee = new Employee();

            Console.WriteLine($"Enter details for employee {i + 1}:");

            Console.Write("Id: ");
            employee.Id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Department: ");
            employee.Department = Console.ReadLine();

            Console.Write("Salary: ");
            employee.Salary = double.Parse(Console.ReadLine());

            employees.Add(employee);
        }

        SerializeEmployees(employees);
        List<Employee> deserializedEmployees = DeserializeEmployees();

        Console.WriteLine("Deserialized Employees:");
        foreach (var employee in deserializedEmployees)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
        }
    }

    public static void SerializeEmployees(List<Employee> employees)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(employees);
            File.WriteAllText(FilePath, jsonString);
            Console.WriteLine("Employees serialized successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred during serialization: {ex.Message}");
        }
    }

    public static List<Employee> DeserializeEmployees()
    {
        try
        {
            string jsonString = File.ReadAllText(FilePath);
            List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            Console.WriteLine("Employees deserialized successfully.");
            return employees;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred during deserialization: {ex.Message}");
            return new List<Employee>();
        }
    }
}
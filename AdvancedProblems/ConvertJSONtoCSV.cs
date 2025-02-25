using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

public class ConvertJSONtoCSV
{
    public static void Main(string[] args)
    {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";

        try
        {
            // Convert JSON to CSV
            List<Student> students = ReadJsonFile(jsonFilePath);
            WriteCsvFile(csvFilePath, students);

            // Convert CSV back to JSON
            List<Student> studentsFromCsv = ReadCsvFile(csvFilePath);
            WriteJsonFile("students_from_csv.json", studentsFromCsv);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    public static List<Student> ReadJsonFile(string filePath)
    {
        try
        {
            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Student>>(jsonData);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading JSON file: " + ex.Message);
            throw;
        }
    }

    public static void WriteJsonFile(string filePath, List<Student> students)
    {
        try
        {
            string jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing JSON file: " + ex.Message);
            throw;
        }
    }

    public static void WriteCsvFile(string filePath, List<Student> students)
    {
        try
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(students);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing CSV file: " + ex.Message);
            throw;
        }
    }

    public static List<Student> ReadCsvFile(string filePath)
    {
        try
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                return new List<Student>(csv.GetRecords<Student>());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV file: " + ex.Message);
            throw;
        }
    }
}
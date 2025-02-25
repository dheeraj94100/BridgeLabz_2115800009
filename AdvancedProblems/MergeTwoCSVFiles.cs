using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MergeTwoCSVFiles
{
    static void Main(string[] args)
    {
        string file1 = @"C:\Users\abc\Desktop\BridgeLabz\AdvancedProblems\students1.csv";
        string file2 = @"C:\Users\abc\Desktop\BridgeLabz\AdvancedProblems\students2.csv";
        string outputFile = @"C:\Users\abc\Desktop\BridgeLabz\AdvancedProblems\merged_students.csv";

        var students1 = File.ReadAllLines(file1)
                            .Skip(1)
                            .Select(line => line.Split(','))
                            .ToDictionary(parts => parts[0], parts => new { Name = parts[1], Age = parts[2] });

        var students2 = File.ReadAllLines(file2)
                            .Skip(1)
                            .Select(line => line.Split(','))
                            .ToDictionary(parts => parts[0], parts => new { Marks = parts[1], Grade = parts[2] });

        var mergedData = from s1 in students1
                         join s2 in students2 on s1.Key equals s2.Key
                         select new
                         {
                             ID = s1.Key,
                             Name = s1.Value.Name,
                             Age = s1.Value.Age,
                             Marks = s2.Value.Marks,
                             Grade = s2.Value.Grade
                         };

        using (var writer = new StreamWriter(outputFile))
        {
            writer.WriteLine("ID,Name,Age,Marks,Grade");
            foreach (var student in mergedData)
            {
                writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks},{student.Grade}");
            }
        }

        Console.WriteLine("CSV files merged successfully.");
    }
}
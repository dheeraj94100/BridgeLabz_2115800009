using System;
using System.Collections.Generic;
using System.IO;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public override string ToString()
    {
        string s = "Id: " + Id + ", Name: " + Name + ", Age: " + Age + ", Marks: " + Marks;
        return s;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string csvFilePath = "students.csv";
        List<Student> students = new List<Student>();

        try
        {
            using (StreamReader sr = new StreamReader(csvFilePath))
            {
                string line;
                line = sr.ReadLine(); // Skip header line
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    if (values.Length == 4)
                    {
                        Student student = new Student
                        {
                            Id = int.Parse(values[0]),
                            Name = values[1],
                            Age = int.Parse(values[2]),
                            Marks = int.Parse(values[3])
                        };

                        students.Add(student);
                    }
                    else
                    {
                        Console.WriteLine("Skipping invalid line: " + line);
                    }
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
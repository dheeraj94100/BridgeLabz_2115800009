using System;
using System.IO;

class DataStreams
{
    static void Main(string[] args)
    {
        string filePath = "studentData.bin";

        // Store student details
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(1); // Roll number
            writer.Write("John"); // Name
            writer.Write(3.75); // GPA
        }

        // Retrieve student details
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int rollNumber = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"GPA: {gpa}");
        }
    }
}
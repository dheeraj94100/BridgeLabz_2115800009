using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the text file
        string filePath = "a.txt"; // Replace with your file path

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        // Use StreamReader to read the file line by line
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            int lineNumber = 1;

            // Read each line and print it to the console
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine($"Line {lineNumber}: {line}");
                lineNumber++;
            }
        }
    }
}
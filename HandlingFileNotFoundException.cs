using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "data.txt";
        
        try
        {
            // Ensure the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found");
                return;
            }
            
            // Open the file and read its content
            using (StreamReader sr = new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("File Contents:");
                Console.WriteLine(content);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
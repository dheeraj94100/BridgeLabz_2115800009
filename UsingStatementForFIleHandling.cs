using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "info.txt";
        
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string firstLine = sr.ReadLine();
                Console.WriteLine("First line of file: " + firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}

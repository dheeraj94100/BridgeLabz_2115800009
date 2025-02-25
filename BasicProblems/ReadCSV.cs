using System;
using System.IO;

class ReadCSV
{
    static void Main(string[] args)
    {
        string filePath = @"students.csv";

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] details = line.Split(',');

                    if (details.Length == 4)
                    {
                        Console.WriteLine("ID: {0}, Name: {1}, Age: {2}, Marks: {3}", 
                            details[0], details[1], details[2], details[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format in line: {0}", line);
                    }
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("The file was not found: '{0}'", e);
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read: '{0}'", e);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: '{0}'", e);
        }
    }
}
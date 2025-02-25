using System;
using System.IO;

class SearchForRecordInCSV
{
    static void Main(string[] args)
    {
        string filePath = @"employees.csv";
        Console.Write("Enter the employee name to search: ");
        string employeeName = Console.ReadLine();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                bool recordFound = false;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[1].Equals(employeeName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Department: " +fields[2] + " Salary: " + fields[3]);
                        recordFound = true;
                        break;
                    }
                }

                if (!recordFound)
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: {ex.Message}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

class SearchForRecordInCSV
{
    static void Main(string[] args)
    {
        string filePath = @"employees.csv";
        string departmentName = "IT";
        string newFilePath = @"updated_employees.csv";
        List<string> updatedLines = new List<string>();
        updatedLines.Add("ID,Name,Department,Salary");
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                bool recordFound = false;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[2].Equals(departmentName, StringComparison.OrdinalIgnoreCase))
                    {
                        fields[3] = Convert.ToString(Convert.ToInt32(fields[3]) * 1.1);
                        recordFound = true;
                        updatedLines.Add(string.Join(",", fields));
                    }
                }

                if (recordFound)
                {
                    File.WriteAllLines(newFilePath, updatedLines);
                    Console.WriteLine("The file has been updated.");
                }
                else
                {
                    Console.WriteLine("No matching records found.");
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
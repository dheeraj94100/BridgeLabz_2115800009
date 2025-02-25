using System;
using System.Collections.Generic;
using System.IO;

class FilterRecordsFromCSV
{
    static void Main(string[] args)
    {
        string filePath = "students.csv";
        List<string> qualifyingRecords = new List<string>();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                line = sr.ReadLine();//skip the header
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[3]) > 80)
                    {
                        qualifyingRecords.Add(line);
                    }
                }
            }

            Console.WriteLine("Students who scored more than 80 marks:");
            foreach (string record in qualifyingRecords)
            {
                Console.WriteLine(record);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("The file was not found: " + e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("An IO exception occurred: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred: " + e.Message);
        }
    }
}
using System;
using System.IO;

class ReadLargeCSVFilesEfficiently
{
    static void Main(string[] args)
    {
        string filePath = "student.csv";
        int chunkSize = 100;
        int totalRecordsProcessed = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int lineCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    // Process the line here
                    // For example, you can split the line by commas and process each field
                    string[] fields = line.Split(',');

                    if (lineCount % chunkSize == 0)
                    {
                        totalRecordsProcessed += chunkSize;
                        Console.WriteLine($"Processed {totalRecordsProcessed} records so far.");
                    }
                }

                // Process any remaining lines that didn't complete a full chunk
                if (lineCount % chunkSize != 0)
                {
                    totalRecordsProcessed += lineCount % chunkSize;
                    Console.WriteLine($"Processed {totalRecordsProcessed} records in total.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
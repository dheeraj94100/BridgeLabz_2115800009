using System;
using System.IO;

class ReadAndCountRows
{
    static void Main(string[] args)
    {
        string filePath = "students.csv";

        try
        {
            int rowCount = 0;
            using (var reader = new StreamReader(filePath))
            {
                // Skip the header row
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    reader.ReadLine();
                    rowCount++;
                }
            }

            Console.WriteLine(rowCount);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
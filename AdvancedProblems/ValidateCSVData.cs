using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCSVData
{
    static void Main(string[] args)
    {
        string filePath = "data.csv";
        List<string> invalidRows = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine();
                string line;
                int lineNumber = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    string[] columns = line.Split(',');

                    if (!IsValidEmail(columns[0]) || !IsValidPhoneNumber(columns[1]))
                    {
                        string temp = "Row " + lineNumber + ": " + line;
                        invalidRows.Add(temp);
                    }
                }
            }

            if (invalidRows.Count > 0)
            {
                Console.WriteLine("Invalid rows found:");
                foreach (string invalidRow in invalidRows)
                {
                    Console.WriteLine(invalidRow);
                }
            }
            else
            {
                Console.WriteLine("All rows are valid.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static bool IsValidEmail(string email)
    {
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }

    static bool IsValidPhoneNumber(string phoneNumber)
    {
        string phonePattern = @"^\d{10}$";
        return Regex.IsMatch(phoneNumber, phonePattern);
    }
}
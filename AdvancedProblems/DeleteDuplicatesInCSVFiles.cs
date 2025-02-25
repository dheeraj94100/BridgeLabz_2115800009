using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdvancedProblems
{
    class DeleteDuplicatesInCSVFiles
    {
        static void Main(string[] args)
        {
            string filePath = "duplicates.csv";
            try
            {
                var lines = File.ReadAllLines(filePath);
                var duplicates = lines
                    .Skip(1)
                    .Select(line => line.Split(','))
                    .GroupBy(fields => fields[0])
                    .Where(group => group.Count() > 1)
                    .SelectMany(group => group);

                Console.WriteLine("Duplicate Records:");
                foreach (var duplicate in duplicates)
                {
                    Console.WriteLine(string.Join(",", duplicate));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class CSVtoJSON
{
    static void Main(string[] args)
    {
        string csvFilePath = "csvfile.csv";
        string jsonFilePath = "outputfile.json";

        var csvData = File.ReadAllLines(csvFilePath);
        var headers = csvData[0].Split(',');

        var jsonList = new List<Dictionary<string, string>>();

        for (int i = 1; i < csvData.Length; i++)
        {
            var row = csvData[i].Split(',');
            var rowDict = new Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
            {
                rowDict[headers[j]] = row[j];
            }

            jsonList.Add(rowDict);
        }

        var json = JsonConvert.SerializeObject(jsonList, Formatting.Indented);
        File.WriteAllText(jsonFilePath, json);

        Console.WriteLine("CSV data has been successfully converted to JSON.");
    }
}
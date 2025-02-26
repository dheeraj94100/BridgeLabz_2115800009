using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

class ReadJSONFile
{
    static void Main(string[] args)
    {
        string filePath = "file.json";
        if (File.Exists(filePath))
        {
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);

            PrintJson(jsonObject);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    static void PrintJson(JObject jsonObject)
    {
        foreach (KeyValuePair<string, JToken> property in jsonObject)
        {
            Console.WriteLine($"{property.Key}: {property.Value}");
        }
    }
}
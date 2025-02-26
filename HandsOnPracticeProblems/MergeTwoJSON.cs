using System;
using System.IO;
using Newtonsoft.Json.Linq;

class MergeTwoJSON
{
    static void Main(string[] args)
    {
        string jsonFilePath1 = @"file1.json";
        string jsonFilePath2 = @"file2.json";

        // Read the JSON files
        string json1 = File.ReadAllText(jsonFilePath1);
        string json2 = File.ReadAllText(jsonFilePath2);

        // Parse the JSON strings into JObject
        JObject jsonObject1 = JObject.Parse(json1);
        JObject jsonObject2 = JObject.Parse(json2);

        // Merge the two JSON objects
        jsonObject1.Merge(jsonObject2, new JsonMergeSettings
        {
            MergeArrayHandling = MergeArrayHandling.Union
        });

        // Output the merged JSON object
        string mergedJson = jsonObject1.ToString();
        Console.WriteLine(mergedJson);

        // Optionally, save the merged JSON to a new file
        string mergedJsonFilePath = @"jsonfile.json";
        File.WriteAllText(mergedJsonFilePath, mergedJson);
    }
}
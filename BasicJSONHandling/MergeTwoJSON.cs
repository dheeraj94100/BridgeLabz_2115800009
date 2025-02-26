using System;
using Newtonsoft.Json.Linq;

class MergeTwoJSON
{
    static void Main(string[] args)
    {
        string json1 = @"{ 'Name': 'John', 'Age': 30 }";
        string json2 = @"{ 'City': 'New York', 'Country': 'USA' }";

        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);

        obj1.Merge(obj2, new JsonMergeSettings
        {
            MergeArrayHandling = MergeArrayHandling.Union
        });

        Console.WriteLine(obj1.ToString());
    }
}
using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace BasicJSONHandling
{
    class ReadJSONFile
    {
        static void Main(string[] args)
        {
            string filePath = @"file.json";
            string jsonContent = File.ReadAllText(filePath);

            JObject jsonObject = JObject.Parse(jsonContent);

            string name = jsonObject["name"]?.ToString();
            string email = jsonObject["email"]?.ToString();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
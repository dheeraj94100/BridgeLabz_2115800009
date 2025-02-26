using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasicJSONHandling
{
    class CreateJSONObject
    {
        static void Main(string[] args)
        {
            JObject student = new JObject(
                new JProperty("name", "John Doe"),
                new JProperty("age", 20),
                new JProperty("subjects", new JArray("Math", "Science", "History"))
            );

            string jsonString = student.ToString();
            Console.WriteLine(jsonString);
        }
    }
}
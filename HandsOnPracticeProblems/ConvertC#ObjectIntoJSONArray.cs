using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace BasicJSONHandling
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    class ListToJSONArray
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 30 },
                new Person { Name = "Jane", Age = 25 },
                new Person { Name = "Tom", Age = 35 }
            };


            string jsonArray = JsonConvert.SerializeObject(people, Formatting.Indented);
            Console.WriteLine(jsonArray);
        }
    }
}

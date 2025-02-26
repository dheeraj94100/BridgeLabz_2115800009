using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace BasicJSONHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"
            [
                { 'name': 'John', 'age': 30 },
                { 'name': 'Jane', 'age': 22 },
                { 'name': 'Doe', 'age': 27 }
            ]";

            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json);
            var filteredPeople = people.Where(p => p.Age > 25).ToList();

            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
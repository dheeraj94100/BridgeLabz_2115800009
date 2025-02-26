using System;
using Newtonsoft.Json;

namespace BasicJSONHandling
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2020
            };

            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
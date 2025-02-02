using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Person
    {
        public string Name { get; }
        public int Age { get; }

        // Parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy Constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Person Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter person's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter person's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person p1 = new Person(name, age);
            p1.Display();

            Person p2 = new Person(p1);  // Cloning p1
            p2.Display();
        }
    }
}

using System;

namespace EmployeeManagement
{
    // Base class Employee
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
        }
    }

    // Subclass Manager
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }

    // Subclass Developer
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, int id, double salary, string programmingLanguage)
            : base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
        }
    }

    // Subclass Intern
    public class Intern : Employee
    {
        public string InternshipDuration { get; set; }

        public Intern(string name, int id, double salary, string internshipDuration)
            : base(name, id, salary)
        {
            InternshipDuration = internshipDuration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Internship Duration: {InternshipDuration}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Alice", 1, 90000, 10);
            Developer developer = new Developer("Bob", 2, 80000, "C#");
            Intern intern = new Intern("Charlie", 3, 30000, "6 months");

            manager.DisplayDetails();
            developer.DisplayDetails();
            intern.DisplayDetails();
        }
    }
}
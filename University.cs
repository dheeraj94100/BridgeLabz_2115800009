using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Student
    {
        public int RollNumber { get; set; }  // Public
        protected string Name { get; set; }  // Protected
        private double CGPA;  // Private

        // Constructor
        public Student(int rollNumber, string name, double cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            CGPA = cgpa;
        }

        // Public method to access CGPA
        public double GetCGPA()
        {
            return CGPA;
        }

        // Public method to update CGPA
        public void SetCGPA(double newCgpa)
        {
            CGPA = newCgpa;
        }
    }

    // Subclass demonstrating protected access
    class PostgraduateStudent : Student
    {
        public string ResearchTopic { get; set; }

        public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
            : base(rollNumber, name, cgpa)
        {
            ResearchTopic = researchTopic;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Roll No: {RollNumber}, Name: {Name}, Research Topic: {ResearchTopic}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Roll Number: ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter CGPA: ");
            double cgpa = Convert.ToDouble(Console.ReadLine());

            Student myStudent = new Student(rollNumber, studentName, cgpa);
            Console.WriteLine($"Student Created: Roll No: {myStudent.RollNumber}, CGPA: {myStudent.GetCGPA()}");
        }
    }
}

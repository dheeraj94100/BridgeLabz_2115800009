using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Course
    {
        public string CourseName { get; set; }  // Instance Variable
        public int Duration { get; set; }       // Instance Variable (Duration in months)
        public double Fee { get; set; }         // Instance Variable
        public static string InstituteName = "GLA University"; // Class Variable (Shared)

        // Constructor
        public Course(string courseName, int duration, double fee)
        {
            CourseName = courseName;
            Duration = duration;
            Fee = fee;
        }

        // Instance Method to Display Course Details
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course: {CourseName}, Duration: {Duration} months, Fee: {Fee}, Institute: {InstituteName}");
        }

        // Class Method to Update Institute Name
        public static void UpdateInstituteName(string newInstituteName)
        {
            InstituteName = newInstituteName;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();
            Console.Write("Enter Course Duration (months): ");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course Fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            // Create Course Object
            Course myCourse = new Course(courseName, duration, fee);
            myCourse.DisplayCourseDetails();

            Console.Write("Enter new Institute Name: ");
            string newInstituteName = Console.ReadLine();
            Course.UpdateInstituteName(newInstituteName); // Updating class variable

            Console.WriteLine($"Updated Institute Name: {Course.InstituteName}");

            // Display updated details to verify the change
            myCourse.DisplayCourseDetails();
        }
    }
}

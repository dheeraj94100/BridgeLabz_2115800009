using System;

class Student
{
    private static string UniversityName = "XYZ University";  // Static variable shared by all students
    private static int TotalStudents = 0;  // Static counter for total students

    public readonly int RollNumber;  // Readonly variable (cannot change after assignment)
    public string Name;
    public string Grade;

    // Constructor using 'this' to initialize properties
    public Student(string Name, string Grade)
    {
        this.RollNumber = ++TotalStudents;  // Auto-increment unique roll number
        this.Name = Name;
        this.Grade = Grade;
    }

    // Static method to get the total number of students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine($"Total Students Enrolled: {TotalStudents}");
    }

    // Display student details using 'is' operator for type checking
    public void DisplayStudentInfo()
    {
        if (this is Student)  // Checking if object is an instance of Student
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"University: {UniversityName}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Grade: {Grade}\n");
        }
        else
        {
            Console.WriteLine("Invalid student record!");
        }
    }

    // Update student grade using 'is' operator for type checking
    public void UpdateGrade(string newGrade)
    {
        if (this is Student)
        {
            Grade = newGrade;
            Console.WriteLine($"Grade updated to {Grade} for {Name}.");
        }
        else
        {
            Console.WriteLine("Invalid student record!");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students to enroll: ");
        int studentCount = Convert.ToInt32(Console.ReadLine());

        Student[] students = new Student[studentCount];

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"\nEnter details for Student {i + 1}:");

            Console.Write("Enter Student Name: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Grade: ");
            string grade = Convert.ToString(Console.ReadLine());

            students[i] = new Student(name, grade);
        }

        // Display all student details
        Console.WriteLine("\nAll Enrolled Students:");
        foreach (Student student in students)
        {
            student.DisplayStudentInfo();
        }

        // Display total students count
        Student.DisplayTotalStudents();

        // Option to update grade
        Console.Write("\nDo you want to update the grade of any student? (yes/no): ");
        string response = Convert.ToString(Console.ReadLine());

        if (response.ToLower() == "yes")
        {
            Console.Write("Enter the Roll Number of the student to update grade: ");
            int rollNumberToUpdate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the new grade: ");
            string newGrade = Convert.ToString(Console.ReadLine());

            foreach (Student student in students)
            {
                if (student.RollNumber == rollNumberToUpdate)
                {
                    student.UpdateGrade(newGrade);
                }
            }
        }
    }
}

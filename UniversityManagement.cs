using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; }

    public Student(string name)
    {
        Name = name;
        EnrolledCourses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        EnrolledCourses.Add(course);
        course.AddStudent(this);
    }
}

public class Professor
{
    public string Name { get; set; }
    public List<Course> TaughtCourses { get; set; }

    public Professor(string name)
    {
        Name = name;
        TaughtCourses = new List<Course>();
    }

    public void AssignCourse(Course course)
    {
        TaughtCourses.Add(course);
        course.AssignProfessor(this);
    }
}

public class Course
{
    public string CourseName { get; set; }
    public Professor AssignedProfessor { get; private set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string courseName)
    {
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }

    public void AssignProfessor(Professor professor)
    {
        AssignedProfessor = professor;
    }

    public void AddStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }
}

public class UniversityManagement
{
    public static void Main(string[] args)
    {
        // Create instances
        Student student1 = new Student("Alice");
        Student student2 = new Student("Bob");
        Professor professor1 = new Professor("Dr. Smith");
        Course course1 = new Course("Computer Science 101");

        // Enroll students in the course
        student1.EnrollCourse(course1);
        student2.EnrollCourse(course1);

        // Assign professor to the course
        professor1.AssignCourse(course1);

        // Display information
        Console.WriteLine($"{student1.Name} enrolled in {course1.CourseName}");
        Console.WriteLine($"{student2.Name} enrolled in {course1.CourseName}");
        Console.WriteLine($"{professor1.Name} is teaching {course1.CourseName}");
    }
}
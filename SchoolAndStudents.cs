using System;
using System.Collections.Generic;

public class School
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    public School(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}

public class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    public void EnrollInCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
            course.EnrollStudent(this);
        }
    }

    public void ViewEnrolledCourses()
    {
        Console.WriteLine($"{Name} is enrolled in the following courses:");
        foreach (var course in Courses)
        {
            Console.WriteLine(course.Name);
        }
    }
}

public class Course
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    public Course(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        if (!Students.Contains(student))
        {
            Students.Add(student);
        }
    }

    public void ViewEnrolledStudents()
    {
        Console.WriteLine($"The following students are enrolled in {Name}:");
        foreach (var student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }
}

public class Program
{
    public static void Main()
    {
        School school = new School("BridgeLabz School");

        Student student1 = new Student("Alice");
        Student student2 = new Student("Bob");

        Course course1 = new Course("Math");
        Course course2 = new Course("Science");

        student1.EnrollInCourse(course1);
        student1.EnrollInCourse(course2);
        student2.EnrollInCourse(course1);

        school.AddStudent(student1);
        school.AddStudent(student2);

        student1.ViewEnrolledCourses();
        student2.ViewEnrolledCourses();

        course1.ViewEnrolledStudents();
        course2.ViewEnrolledStudents();
    }
}
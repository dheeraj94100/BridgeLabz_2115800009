using System;
using System.Collections.Generic;

// Abstract class for CourseType
public abstract class CourseType
{
    public string CourseName { get; set; }
    public string Department { get; set; }
    public abstract void Evaluate();
}

// Derived class for ExamCourse
public class ExamCourse : CourseType
{
    public int ExamDuration { get; set; } // in minutes

    public override void Evaluate()
    {
        Console.WriteLine($"Evaluating {CourseName} with an exam of {ExamDuration} minutes.");
    }
}

// Derived class for AssignmentCourse
public class AssignmentCourse : CourseType
{
    public int NumberOfAssignments { get; set; }

    public override void Evaluate()
    {
        Console.WriteLine($"Evaluating {CourseName} with {NumberOfAssignments} assignments.");
    }
}

// Generic class for Course
public class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void EvaluateCourses()
    {
        foreach (var course in courses)
        {
            course.Evaluate();
        }
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of ExamCourse and AssignmentCourse
        var examCourse = new ExamCourse { CourseName = "Math 101", Department = "Mathematics", ExamDuration = 120 };
        var assignmentCourse = new AssignmentCourse { CourseName = "History 101", Department = "History", NumberOfAssignments = 5 };

        // Create Course instances and add courses
        var examCourseList = new Course<ExamCourse>();
        examCourseList.AddCourse(examCourse);

        var assignmentCourseList = new Course<AssignmentCourse>();
        assignmentCourseList.AddCourse(assignmentCourse);

        // Evaluate courses
        examCourseList.EvaluateCourses();
        assignmentCourseList.EvaluateCourses();
    }
}
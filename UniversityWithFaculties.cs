using System;
using System.Collections.Generic;

public class Faculty
{
    public string Name { get; set; }

    public Faculty(string name)
    {
        Name = name;
    }
}

public class Department
{
    public string Name { get; set; }
    public List<Faculty> Faculties { get; set; }

    public Department(string name)
    {
        Name = name;
        Faculties = new List<Faculty>();
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty);
    }
}

public class University
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; }

    public University(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    ~University()
    {
        // Destructor to demonstrate that deleting a university deletes its departments
        Departments.Clear();
        Console.WriteLine("University and its departments are deleted.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create faculty members
        Faculty faculty1 = new Faculty("Dr. Smith");
        Faculty faculty2 = new Faculty("Dr. Johnson");

        // Create departments and add faculty members to them
        Department csDepartment = new Department("Computer Science");
        csDepartment.AddFaculty(faculty1);

        Department mathDepartment = new Department("Mathematics");
        mathDepartment.AddFaculty(faculty2);

        // Create a university and add departments to it
        University university = new University("Tech University");
        university.AddDepartment(csDepartment);
        university.AddDepartment(mathDepartment);

        // Demonstrate that faculty members can exist independently of a department
        Faculty independentFaculty = new Faculty("Dr. Brown");
        Console.WriteLine($"{independentFaculty.Name} exists independently of any department.");

        // Deleting the university (demonstrated by setting it to null and forcing garbage collection)
        university = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
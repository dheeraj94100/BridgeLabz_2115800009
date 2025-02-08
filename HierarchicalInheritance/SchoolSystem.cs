using System;

// Superclass: Person
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor to initialize common attributes
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to display basic details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Virtual method to be overridden
    public virtual void DisplayRole()
    {
        Console.WriteLine("This is a general person in the school.");
    }
}

// Subclass: Teacher
class Teacher : Person
{
    public string Subject { get; set; }

    // Constructor to initialize Teacher details
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    // Overriding method to specify the role
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
    }

    // Overriding method to display teacher details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Subject: {Subject}");
    }
}

// Subclass: Student
class Student : Person
{
    public string Grade { get; set; }

    // Constructor to initialize Student details
    public Student(string name, int age, string grade) : base(name, age)
    {
        Grade = grade;
    }

    // Overriding method to specify the role
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
    }

    // Overriding method to display student details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Grade: {Grade}");
    }
}

// Subclass: Staff
class Staff : Person
{
    public string Department { get; set; }

    // Constructor to initialize Staff details
    public Staff(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }

    // Overriding method to specify the role
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
    }

    // Overriding method to display staff details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Department: {Department}");
    }
}

// Main class to demonstrate functionality
class Program
{
    static void Main()
    {
        // Creating a Teacher object
        Teacher teacher = new Teacher("Rajesh Sharma", 40, "Mathematics");
        teacher.DisplayRole();
        teacher.DisplayDetails();
        
        Console.WriteLine();

        // Creating a Student object
        Student student = new Student("Aarav Mehta", 16, "10th Grade");
        student.DisplayRole();
        student.DisplayDetails();

        Console.WriteLine();

        // Creating a Staff object
        Staff staff = new Staff("Sunita Verma", 35, "Administration");
        staff.DisplayRole();
        staff.DisplayDetails();
    }
}
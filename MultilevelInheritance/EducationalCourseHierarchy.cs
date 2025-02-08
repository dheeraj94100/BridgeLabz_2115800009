using System;

// Base class: Course
class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; } // Duration in weeks

    // Constructor to initialize course details
    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    // Method to display course details
    public virtual void DisplayCourseDetails()
    {
        Console.WriteLine($"Course Name: {CourseName}, Duration: {Duration} weeks");
    }
}

// Subclass: OnlineCourse (Extends Course)
class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    // Constructor to initialize online course details
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    // Overriding method to include online course details
    public override void DisplayCourseDetails()
    {
        Console.WriteLine($"Course Name: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {(IsRecorded ? "Yes" : "No")}");
    }
}

// Subclass: PaidOnlineCourse (Extends OnlineCourse)
class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; } // Discount in percentage

    // Constructor to initialize paid online course details
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    // Method to calculate the final price after discount
    public double GetFinalFee()
    {
        return Fee - (Fee * Discount / 100);
    }

    // Overriding method to include paid course details
    public override void DisplayCourseDetails()
    {
        Console.WriteLine($"Course Name: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {(IsRecorded ? "Yes" : "No")}, Fee: ₹{Fee}, Discount: {Discount}%, Final Price: ₹{GetFinalFee()}");
    }
}

// Main class to demonstrate functionality
class Program
{
    static void Main()
    {
        // Creating a basic course
        Course basicCourse = new Course("Mathematics", 8);
        basicCourse.DisplayCourseDetails();

        Console.WriteLine();

        // Creating an online course
        OnlineCourse onlineCourse = new OnlineCourse("Programming in C#", 10, "Udemy", true);
        onlineCourse.DisplayCourseDetails();

        Console.WriteLine();

        // Creating a paid online course
        PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Advanced Data Science", 12, "Coursera", true, 5000, 20);
        paidOnlineCourse.DisplayCourseDetails();
    }
}
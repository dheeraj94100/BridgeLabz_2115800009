using System;

class Program
{
    static void Main()
    {
        int numberOfStudents;

        // Take the number of students as input
        Console.Write("Enter the number of students: ");
        numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Create a 2D array to store marks for Physics, Chemistry, and Maths for each student
        int[,] marks = new int[numberOfStudents, 3];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];

        // Input marks for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for student {i + 1}:");

            marks[i, 0] = GetValidMark("Physics");
            marks[i, 1] = GetValidMark("Chemistry");
            marks[i, 2] = GetValidMark("Maths");

            double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (totalMarks / 300) * 100;

            // Determine grade based on percentage
            if (percentages[i] >= 80)
                grades[i] = "A";
            else if (percentages[i] >= 70)
                grades[i] = "B";
            else if (percentages[i] >= 60)
                grades[i] = "C";
            else if (percentages[i] >= 50)
                grades[i] = "D";
            else if (percentages[i] >= 40)
                grades[i] = "R";
            else
                grades[i] = "R"; // Fail grade
        }

        // Display the results
        Console.WriteLine("\nResults:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.WriteLine($"Physics: {marks[i, 0]}");
            Console.WriteLine($"Chemistry: {marks[i, 1]}");
            Console.WriteLine($"Maths: {marks[i, 2]}");
            Console.WriteLine($"Percentage: {percentages[i]:F2}%");
            Console.WriteLine($"Grade: {grades[i]}");
        }
    }

    // Method to get a valid mark between 0 and 100
    static int GetValidMark(string subject)
    {
        int mark;
        while (true)
        {
            Console.Write($"Enter marks for {subject}: ");
            mark = Convert.ToInt32(Console.ReadLine());

            if (mark >= 0 && mark <= 100)
                return mark;
            else
                Console.WriteLine("Invalid input! Please enter a valid mark between 0 and 100.");
        }
    }
}
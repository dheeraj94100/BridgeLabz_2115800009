using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        // Input marks for three subjects
        Console.Write("Enter marks for Physics: ");
        double physics = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter marks for Chemistry: ");
        double chemistry = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter marks for Maths: ");
        double maths = Convert.ToDouble(Console.ReadLine());

        // Validate if marks are within 0-100
        if (physics < 0 || physics > 100 || chemistry < 0 || chemistry > 100 || maths < 0 || maths > 100)
        {
            Console.WriteLine("Invalid marks entered. Marks should be between 0 and 100.");
            return;
        }

        // Calculate the total and percentage
        double totalMarks = physics + chemistry + maths;
        double percentage = (totalMarks / 300) * 100;

        // Determine the grade and remarks
        string grade = "";
        string remarks = "";

        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 1, below but approaching agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1-, well below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        // Display the result
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine($"Average Marks: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }
}
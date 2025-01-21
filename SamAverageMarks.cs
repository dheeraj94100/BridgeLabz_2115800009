using System;

class AverageCalculator
{
    static void Main(string[] args)
    {
        int maths = 94;
        int physics = 95;
        int chemistry = 96;
        int totalMarksPerSubject = 100;
        int totalMarksObtained = maths + physics + chemistry;
        int totalMaxMarks = 3 * totalMarksPerSubject; 

        double averagePercent = (double)totalMarksObtained / totalMaxMarks * 100;

        Console.WriteLine($"Sam's average mark in PCM is {averagePercent:F2}%.");//fe is used to print 2 values after decimal
    }
}

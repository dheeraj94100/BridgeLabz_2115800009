using System;

class StudentVoteChecker
{
    static void Main()
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Can vote: " + CanStudentVote(ages[i]));
        }
    }

    static bool CanStudentVote(int age)
    {
        if (age < 0) return false;
        return age >= 18;
    }
}

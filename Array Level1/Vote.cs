using System;

class Program
{
    static void Main()
    {
        // Declare an array to store the ages of 10 students
        int[] ages = new int[10];
        Console.WriteLine("Enter the ages of 10 students:");

        // Loop to take input for each student's age
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Student {i + 1} age: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Check each age to determine voting eligibility
        foreach (int age in ages)
        {
            if (age < 0)
            {
                // Handle invalid age input
                Console.WriteLine("Invalid age");
            }
            else if (age >= 18)
            {
                // Student can vote if age is 18 or above
                Console.WriteLine($"The student with the age {age} can vote.");
            }
            else
            {
                // Student cannot vote if age is less than 18
                Console.WriteLine($"The student with the age {age} cannot vote.");
            }
        }
    }
}

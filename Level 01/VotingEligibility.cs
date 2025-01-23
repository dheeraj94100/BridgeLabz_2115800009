using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        // Taking age input from the user
        Console.Write("Enter the person's age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Checking voting eligibility
        if (age >= 18)
        {
            Console.WriteLine($"The person's age is {age} and can vote.");
        }
        else
        {
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}



using System;

class HandshakeCalculator
{
    static void Main(string[] args)
    {
        // Take user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Validate the input to ensure it's positive
        if (numberOfStudents > 0)
        {
            // Calculate the maximum number of handshakes
            int maxHandshakes = CalculateHandshakes(numberOfStudents);

            // Display the result
            Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}.");
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Number of students must be greater than 0.");
        }
    }

    // Method to calculate the number of handshakes
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}


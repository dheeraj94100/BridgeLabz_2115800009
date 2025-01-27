using System;

class NumberCheck
{
    // Method to determine if the number is positive, negative, or zero
    static int CheckNumber(int number)
    {
        if (number > 0)
            return 1; // Positive number
        else if (number < 0)
            return -1; // Negative number
        else
            return 0; // Zero
    }

    static void Main(string[] args)
    {
        // Prompt user for input
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the method to check the number
        int result = CheckNumber(number);

        // Display the result based on the return value
        if (result == 1)
            Console.WriteLine("The number is positive.");
        else if (result == -1)
            Console.WriteLine("The number is negative.");
        else
            Console.WriteLine("The number is zero.");
    }
}


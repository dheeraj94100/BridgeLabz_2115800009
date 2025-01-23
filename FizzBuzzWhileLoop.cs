using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        // Input: User is asked to enter a number
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Ensure the input is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Initialize counter to 1
        int counter = 1;

        // While loop to check from 1 to the entered number
        while (counter <= number)
        {
            // Check if the number is divisible by both 3 and 5
            if (counter % 3 == 0 && counter % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Check if the number is divisible by 3
            else if (counter % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            // Check if the number is divisible by 5
            else if (counter % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // If none of the conditions are met, print the number
            else
            {
                Console.WriteLine(counter);
            }

            // Increment counter for the next iteration
            counter++;
        }
    }
}
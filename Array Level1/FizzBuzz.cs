using System;

class Program
{
    static void Main()
    {
        // Input the number from the user
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate if the input is positive
        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive integer.");
            return;
        }

        // Create an array to store results
        string[] results = new string[number + 1];

        // Loop to populate the array with FizzBuzz logic
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                results[i] = "FizzBuzz";
            else if (i % 3 == 0)
                results[i] = "Fizz";
            else if (i % 5 == 0)
                results[i] = "Buzz";
            else
                results[i] = i.ToString();
        }

        // Display the results
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}

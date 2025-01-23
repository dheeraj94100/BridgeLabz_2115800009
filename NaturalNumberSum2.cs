using System;

class NaturalNumberSum
{
    static void Main(string[] args)
    {
        // Taking user input for the number
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a natural number
        if (number > 0)
        {
            // Compute the sum using the while loop
            int sumUsingWhile = 0;
            int counter = 1;

            while (counter <= number)
            {
                sumUsingWhile += counter;
                counter++;
            }

            // Compute the sum using the formula n * (n + 1) / 2
            int sumUsingFormula = (number * (number + 1)) / 2;

            // Display the results
            Console.WriteLine($"Sum using while loop: {sumUsingWhile}");
            Console.WriteLine($"Sum using formula: {sumUsingFormula}");

            // Compare the results
            if (sumUsingWhile == sumUsingFormula)
            {
                Console.WriteLine("Both computations are correct.");
            }
            else
            {
                Console.WriteLine("There is an error in the computations.");
            }
        }
        else
        {
            // If the user entered a non-natural number
            Console.WriteLine("Please enter a valid natural number greater than 0.");
        }
    }
}
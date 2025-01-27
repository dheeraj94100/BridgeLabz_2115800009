using System;

class SumOfNaturalNumbers
{
    // Method to calculate the sum of first n natural numbers using a loop
    static int FindSumOfNaturalNumbers(int n)
    {
        int sum = 0;

        // Loop to calculate the sum of natural numbers
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

    static void Main(string[] args)
    {
        // Input: Get the number of natural numbers
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a valid positive integer
        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Call the method to find the sum
            int sum = FindSumOfNaturalNumbers(n);

            // Output the result
            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
        }
    }
}


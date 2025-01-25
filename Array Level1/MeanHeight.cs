using System;

class Program
{
    static void Main()
    {
        // Declare an array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0;

        Console.WriteLine("Enter the heights of 11 football players:");

        // Input the heights and calculate the sum
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Player {i + 1} height: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i];
        }

        // Calculate the mean height
        double mean = sum / heights.Length;

        // Display the mean height
        Console.WriteLine($"The mean height of the football team is: {mean:F2} meters");
    }
}

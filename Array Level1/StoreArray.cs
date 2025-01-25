using System;

class Program
{
    static void Main()
    {
        // Declare an array and variables for total and index
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter numbers (enter 0 or negative to stop):");

        // Infinite loop to take user input until the condition breaks
        while (true)
        {
            Console.Write($"Number {index + 1}: ");
            double input = Convert.ToDouble(Console.ReadLine());

            // Break if input is 0 or negative, or if array limit is reached
            if (input <= 0 || index == 10)
                break;

            // Store the input in the array and increment the index
            numbers[index++] = input;
        }

        // Calculate the total sum of the elements
        Console.WriteLine("The numbers are:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        // Display the total sum
        Console.WriteLine($"The sum of all numbers is: {total}");
    }
}

using System;

class Program
{
    static void Main()
    {
        // Get the number input from the user
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate if the input is a natural number
        if (number < 1)
        {
            Console.WriteLine("Error: Please enter a natural number greater than 0.");
            return;
        }

        // Create arrays for odd and even numbers
        int[] evens = new int[number / 2 + 1];
        int[] odds = new int[number / 2 + 1];
        int evenIndex = 0, oddIndex = 0;

        // Populate the odd and even arrays
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evens[evenIndex++] = i;
            }
            else
            {
                odds[oddIndex++] = i;
            }
        }

        // Display the odd and even numbers
        Console.WriteLine("Odd Numbers: " + string.Join(", ", odds, 0, oddIndex));
        Console.WriteLine("Even Numbers: " + string.Join(", ", evens, 0, evenIndex));
    }
}

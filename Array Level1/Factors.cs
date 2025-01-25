using System;

class Program
{
    static void Main()
    {
        // Input the number from the user
        Console.Write("Enter a number to find its factors: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize variables
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        // Find factors and store them in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                // Resize array if needed
                if (index == maxFactor)
                {
                    maxFactor *= 2;
                    Array.Resize(ref factors, maxFactor);
                }
                factors[index++] = i;
            }
        }

        // Display the factors
        Console.WriteLine($"The factors of {number} are: " + string.Join(", ", factors, 0, index));
    }
}

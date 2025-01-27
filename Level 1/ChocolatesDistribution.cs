using System;

class ChocolatesDistribution
{
    // Method to find how many chocolates each child gets and how many are left
    public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        // Initialize an array to store chocolates per child and the remaining chocolates
        int[] result = new int[2];
        
        // Calculate how many chocolates each child gets (quotient)
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        
        // Calculate how many chocolates remain (remainder)
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Store the results in the array: [0] = chocolates per child, [1] = remaining chocolates
        result[0] = chocolatesPerChild;
        result[1] = remainingChocolates;
        
        return result;
    }

    static void Main(string[] args)
    {
        // Input: Get the number of chocolates and children from the user
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Check if the number of children is zero to avoid division by zero
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Error: Number of children cannot be zero.");
        }
        else
        {
            // Call the method to find chocolates per child and remaining chocolates
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            // Output the number of chocolates each child gets and the remaining chocolates
            Console.WriteLine($"Each child gets {result[0]} chocolates.");
            Console.WriteLine($"Remaining chocolates: {result[1]}.");
        }
    }
}


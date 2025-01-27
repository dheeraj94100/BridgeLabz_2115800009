using System;

class SmallestAndLargest
{
    // Method to find the smallest and largest of three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        // Initialize an array to store the smallest and largest numbers
        int[] result = new int[2];
        
        // Find the smallest number
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        
        // Find the largest number
        int largest = Math.Max(number1, Math.Max(number2, number3));

        // Store the smallest and largest in the result array
        result[0] = smallest;  // Smallest
        result[1] = largest;   // Largest
        
        return result;
    }

    static void Main(string[] args)
    {
        // Input: Get 3 numbers from the user
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        // Call the method to find smallest and largest
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Output the smallest and largest numbers
        Console.WriteLine($"The smallest number is: {result[0]}");
        Console.WriteLine($"The largest number is: {result[1]}");
    }
}


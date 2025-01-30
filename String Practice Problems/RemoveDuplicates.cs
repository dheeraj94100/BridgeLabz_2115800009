using System;

class RemoveDuplicates
{
    public static string RemoveDuplicateChars(string input)
    {
        // Create a StringBuilder to store the result
        // StringBuilder is more efficient than using string concatenation
        StringBuilder result = new StringBuilder();
        // Iterate through each character in the input string
        foreach (char c in input)
        {
            // Check if the character is already in the result
            if (result.ToString().IndexOf(c) == -1)
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string output = RemoveDuplicateChars(input);
        Console.WriteLine("String after removing duplicates: " + output);
    }
}
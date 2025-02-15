using System;
using System.Text;

class RemoveDuplicates
{
    public static string RemoveDuplicateChars(string input)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder seen = new StringBuilder();

        foreach (char c in input)
        {
            if (seen.ToString().IndexOf(c) == -1)
            {
                seen.Append(c);
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

using System;

class MostFrequentCharacter
{
    static void Main()
    {
        // Input string to find the most frequent character
        string input = "success";
        
        // Call the method to find the most frequent character
        char mostFrequentChar = FindMostFrequentCharacter(input);
        
        // Print the most frequent character
        Console.WriteLine("Most Frequent Character: '{0}'", mostFrequentChar);
    }

    static char FindMostFrequentCharacter(string input)
    {
        // Array to keep count of each character (assuming ASCII)
        int[] charCount = new int[256];
        
        // Variables to keep track of the maximum count and the result character
        int maxCount = 0;
        char result = ' ';

        // Iterate through each character in the input string
        foreach (char c in input)
        {
            // Increment the count of the character
            charCount[c]++;
            
            // Update the result if the current character count is greater than maxCount
            if (charCount[c] > maxCount)
            {
                maxCount = charCount[c];
                result = c;
            }
        }

        // Return the most frequent character
        return result;
    }
}
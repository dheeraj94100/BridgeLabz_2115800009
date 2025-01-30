using System;

class ReplaceWord
{
    // Method to replace oldWord with newWord in the given sentence
    public static string Replace(string sentence, string oldWord, string newWord)
    {
        // Split the sentence into words
        string[] words = sentence.Split(' ');
        // Create a new string to store the result
        string result = "";
        // Iterate through each word in the sentence
        foreach (string word in words)
        {
            // Check if the word is equal to the old word
            if (word == oldWord)
            {
                // If it is, replace it with the new word
                result += newWord + " ";
            }
            else
            {
                // Otherwise, keep the original word
                result += word + " ";
            }
        }
        // Remove the extra space at the end of the result
        return result.Trim();
    }

    static void Main(string[] args)
    {
        // Read input sentence from the console
        string sentence = Console.ReadLine();
        // Read the word to be replaced from the console
        string oldWord = Console.ReadLine();
        // Read the new word from the console
        string newWord = Console.ReadLine();

        // Call the Replace method and store the result
        string result = Replace(sentence, oldWord, newWord);
        // Print the result to the console
        Console.WriteLine(result);
    }
}
using System;

class ReplaceWord
{
    // Method to replace oldWord with newWord in the given sentence
    public static string Replace(string sentence, string oldWord, string newWord)
    {
        return sentence.Replace(oldWord, newWord);
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
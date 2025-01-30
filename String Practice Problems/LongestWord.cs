using System;

class LongestWordFinder
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("The longest word is: " + longestWord);
    }

    static string FindLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longestWord = string.Empty;

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }
}
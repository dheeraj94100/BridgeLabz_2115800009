using System;

class SearchForSpecificWord
{
    static void Main()
    {
        Console.WriteLine("Enter the number of sentences:");
        int numberOfSentences = int.Parse(Console.ReadLine());

        string[] sentences = new string[numberOfSentences];
        for (int i = 0; i < numberOfSentences; i++)
        {
            Console.WriteLine($"Enter sentence {i + 1}:");
            sentences[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter the word to search for:");
        string word = Console.ReadLine();

        int index = LinearSearch(sentences, word);

        if (index != -1)
        {
            Console.WriteLine($"The first sentence containing the word '{word}' is: \"{sentences[index]}\"");
        }
        else
        {
            Console.WriteLine($"The word '{word}' was not found in any sentence.");
        }
    }

    static int LinearSearch(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                return i;
            }
        }
        return -1;
    }
}
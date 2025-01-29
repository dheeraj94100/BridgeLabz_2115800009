using System;

class CountVowelsConsonants
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        int vowelCount = 0;
        int consonantCount = 0;

        foreach (char c in input.ToLower())
        {
            if ("aeiou".IndexOf(c) >= 0)
            {
                vowelCount++;
            }
            else if (char.IsLetter(c))
            {
                consonantCount++;
            }
        }

        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Number of consonants: " + consonantCount);
    }
}
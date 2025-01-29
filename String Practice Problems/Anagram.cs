using System;

class Anagram
{
    static void Main()
    {
        // Prompt user to enter the first string
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        // Prompt user to enter the second string
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        // Check if the strings are anagrams and display the result
        if (IsAnagram(str1, str2))
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }

    static bool IsAnagram(string str1, string str2)
    {
        // If lengths are not equal, they cannot be anagrams
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Convert strings to lowercase and to character arrays
        char[] charArray1 = str1.ToLower().ToCharArray();
        char[] charArray2 = str2.ToLower().ToCharArray();

        // Sort the character arrays
        Array.Sort(charArray1);
        Array.Sort(charArray2);

        // Compare sorted character arrays
        for (int i = 0; i < charArray1.Length; i++)
        {
            if (charArray1[i] != charArray2[i])
            {
                return false;
            }
        }
        return true;
    }
}
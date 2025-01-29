using System;

class SubstringOccurrences
{
    static void Main()
    {
        // string str = "hellohellohello";
        string str = Console.ReadLine();
        // string substr = "hello";
        string substr = Console.ReadLine();
        int count = CountSubstringOccurrences(str, substr);
        Console.WriteLine($"The substring '{substr}' occurs {count} times in the string.");
    }

    static int CountSubstringOccurrences(string str, string substr)
    {
        int count = 0;
        int index = 0;

        while ((index = str.IndexOf(substr, index)) != -1)
        {
            count++;
            index += substr.Length;
        }
        return count;
    }
}
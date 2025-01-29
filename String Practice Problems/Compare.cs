using System;

class CompareStrings
{
    static int CompareLexicographically(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                return -1;
            }
            else if (str1[i] > str2[i])
            {
                return 1;
            }
        }

        if (str1.Length < str2.Length)
        {
            return -1;
        }
        else if (str1.Length > str2.Length)
        {
            return 1;
        }

        return 0;
    }

    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        int result = CompareLexicographically(str1, str2);

        if (result == 0)
        {
            Console.WriteLine("The strings are equal.");
        }
        else if (result < 0)
        {
            Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + " in lexicographical order.");
        }
        else
        {
            Console.WriteLine("\"" + str2 + "\" comes before \"" + str1 + " in lexicographical order.");
        }
    }
}
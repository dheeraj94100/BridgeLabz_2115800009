using System;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder(input);
        for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
        {
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
        }
        Console.WriteLine("Reversed string: " + sb.ToString());
    }
}
using System;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();
        string reversed = Reverse(input);
        Console.WriteLine("Reversed string: " + reversed);
    }

    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;

        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }

        return new string(charArray);
    }
}
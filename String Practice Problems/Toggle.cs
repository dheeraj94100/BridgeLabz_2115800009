using System;   
class ToggleCase
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string toggledString = ToggleCaseOfString(input);
        Console.WriteLine("Toggled case string: " + toggledString);
    }
    static string ToggleCaseOfString(string str)
    {
        char[] charArray = str.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
            else if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }
        return new string(charArray);
    }
}
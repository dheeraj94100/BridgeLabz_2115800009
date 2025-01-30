using System;

class SpecificCharacter
{
    static void Main()
    {
        // Reads the input string from the console.
        string inputString = Console.ReadLine();
        
        // Reads the character to remove from the console.
        char charToRemove = Console.ReadLine()[0];
        
        // Calls the RemoveCharacter method to remove the specified character from the input string.
        string modifiedString = RemoveCharacter(inputString, charToRemove);
        
        // Outputs the modified string to the console.
        Console.WriteLine("Modified String: \"" + modifiedString + "\"");
    }
    static string RemoveCharacter(string str, char charToRemove)
    {
        // Replaces all occurrences of the specified character with an empty string.
        string temp = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != charToRemove)
            {
                temp += str[i];
            }
        }
        return temp;
    }
}
using System;

class PalindromeChecker
{
   
    static void Main()
    {
        // Get the string from the user
        string input = GetInput("Enter a string to check if it's a palindrome: ");
        
        // Check if the string is a palindrome and output the result
        if (IsPalindrome(input))
            Console.WriteLine($"{input} is a palindrome.");
        else
            Console.WriteLine($"{input} is not a palindrome.");
    }

   
    static string GetInput(string prompt)
    {
        Console.Write(prompt); 
        return Console.ReadLine(); 
    }

    // Method to check if a string is a palindrome
    static bool IsPalindrome(string str)
    {
        string reversed = new string(str.Reverse().ToArray());
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
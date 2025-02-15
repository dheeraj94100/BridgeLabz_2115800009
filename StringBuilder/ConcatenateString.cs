using System;
using System.Text;

class ConcatenateString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of strings you want to concatenate:");
        int n = int.Parse(Console.ReadLine());

        string[] stringArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter string {i + 1}:");
            stringArray[i] = Console.ReadLine();
        }

        StringBuilder stringBuilder = new StringBuilder();

        foreach (string str in stringArray)
        {
            stringBuilder.Append(str);
        }

        string result = stringBuilder.ToString();
        Console.WriteLine("Concatenated string:");
        Console.WriteLine(result);
    }
}
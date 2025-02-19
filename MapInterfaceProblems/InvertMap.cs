using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Take input from the user
        Console.WriteLine("Enter the number of key-value pairs:");
        int count = Convert.ToInt32(Console.ReadLine());

        Dictionary<string, int> inputDict = new Dictionary<string, int>();

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter key {i + 1}:");
            string key = Console.ReadLine();

            Console.WriteLine($"Enter value {i + 1}:");
            int value = Convert.ToInt32(Console.ReadLine());

            inputDict[key] = value;
        }

        // Step 2: Invert the dictionary
        Dictionary<int, List<string>> invertedDict = new Dictionary<int, List<string>>();

        foreach (var kvp in inputDict)
        {
            if (!invertedDict.ContainsKey(kvp.Value))
            {
                invertedDict[kvp.Value] = new List<string>();
            }
            invertedDict[kvp.Value].Add(kvp.Key);
        }

        // Step 3: Print the inverted dictionary
        Console.WriteLine("Inverted Dictionary:");
        foreach (var kvp in invertedDict)
        {
            Console.WriteLine($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
        }
    }
}
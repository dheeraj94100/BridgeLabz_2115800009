using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Input list of strings
        List<string> fruits = new List<string> { "apple", "banana", "apple", "orange" };

        // Get the frequency of each element
        Dictionary<string, int> frequencyMap = GetFrequency(fruits);

        // Print the results
        foreach (var pair in frequencyMap)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    // Method to count the frequency of each element in the list
    static Dictionary<string, int> GetFrequency(List<string> list)
    {
        Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

        foreach (string item in list)
        {
            if (frequencyMap.ContainsKey(item))
            {
                // If the item already exists in the dictionary, increment its count
                frequencyMap[item]++;
            }
            else
            {
                // If the item does not exist, add it to the dictionary with a count of 1
                frequencyMap[item] = 1;
            }
        }

        return frequencyMap;
    }
}
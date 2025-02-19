using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> RemoveDuplicates(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int num in list)
        {
            if (!seen.Contains(num))
            {
                seen.Add(num);
                result.Add(num);
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter the list elements separated by space: ");
        List<int> list = Console.ReadLine()
                                .Split(' ')
                                .Select(x => Convert.ToInt32(x))
                                .ToList();

        List<int> uniqueList = RemoveDuplicates(list);
        
        Console.WriteLine("List after removing duplicates: " + string.Join(", ", uniqueList));
    }
}

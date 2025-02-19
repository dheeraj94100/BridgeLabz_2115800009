using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.SetEquals(set2);
    }

    static void Main()
    {
        Console.Write("Enter elements of Set1 separated by space: ");
        HashSet<int> set1 = new HashSet<int>(Console.ReadLine()
                                   .Split(' ')
                                   .Select(x => Convert.ToInt32(x)));

        Console.Write("Enter elements of Set2 separated by space: ");
        HashSet<int> set2 = new HashSet<int>(Console.ReadLine()
                                   .Split(' ')
                                   .Select(x => Convert.ToInt32(x)));

        bool isEqual = AreSetsEqual(set1, set2);
        Console.WriteLine("Are the sets equal? " + isEqual);
    }
}

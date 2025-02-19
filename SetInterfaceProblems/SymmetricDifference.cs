using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
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

        HashSet<int> symmetricDifference = new HashSet<int>(set1);
        symmetricDifference.SymmetricExceptWith(set2);

        // Displaying the result
        Console.WriteLine("Symmetric Difference: {" + string.Join(", ", symmetricDifference) + "}");
    }
}

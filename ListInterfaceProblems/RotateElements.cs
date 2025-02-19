using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> RotateList(List<int> list, int positions)
    {
        int length = list.Count;
        positions = positions % length; // Handle cases where positions > length

        List<int> rotated = list.Skip(positions).Concat(list.Take(positions)).ToList();
        return rotated;
    }

    static void Main()
    {
        Console.Write("Enter the list elements separated by space: ");
        List<int> list = Console.ReadLine()
                                .Split(' ')
                                .Select(x => Convert.ToInt32(x))
                                .ToList();

        Console.Write("Enter the number of positions to rotate: ");
        int positions = Convert.ToInt32(Console.ReadLine());

        List<int> rotatedList = RotateList(list, positions);

        Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
    }
}

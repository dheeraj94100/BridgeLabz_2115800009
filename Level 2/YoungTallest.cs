using System;

class FriendsComparison
{
    static void Main()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of friend {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of friend {i + 1} (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Youngest friend age: " + FindYoungest(ages));
        Console.WriteLine("Tallest friend height: " + FindTallest(heights));
    }

    static int FindYoungest(int[] ages)
    {
        int youngest = ages[0];
        foreach (int age in ages)
        {
            if (age < youngest) youngest = age;
        }
        return youngest;
    }

    static double FindTallest(double[] heights)
    {
        double tallest = heights[0];
        foreach (double height in heights)
        {
            if (height > tallest) tallest = height;
        }
        return tallest;
    }
}

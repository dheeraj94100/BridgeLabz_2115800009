using System;
class FootBall
{
    static void Main(string[] args)
    {
        int[] heights = new int[11];
        Random rand = new Random();

        // Generate random heights for players
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = rand.Next(150, 251);
        }

        int sum = FindSum(heights);
        double mean = FindMean(sum, heights.Length);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);
        // Display results
        Console.WriteLine("Heights of players: " + string.Join(", ", heights));
        Console.WriteLine("Sum of heights: " + sum);
        Console.WriteLine("Mean height: " + mean);
        Console.WriteLine("Shortest height: " + shortest);
        Console.WriteLine("Tallest height: " + tallest);
    }

    static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    static double FindMean(int sum, int count)
    {
        return (double)sum / count;
    }

    static int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    static int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}
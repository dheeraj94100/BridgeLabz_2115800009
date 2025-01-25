using System;

class YoungestAndTallest
{
    static void Main(string[] args)
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        float[] heights = new float[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the age of {friends[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write($"Enter the height of {friends[i]} (in cm): ");
            heights[i] = float.Parse(Console.ReadLine());
        }
        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        Console.WriteLine($"The youngest friend is {friends[youngestIndex]} with age {ages[youngestIndex]}.");
        Console.WriteLine($"The tallest friend is {friends[tallestIndex]} with height {heights[tallestIndex]} cm.");
    }
}
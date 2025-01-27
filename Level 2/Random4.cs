using System;

class Program
{
    static void Main()
    {
        int[] randomNumbers = Generate4DigitRandomArray(5);

        double[] results = FindAverageMinMax(randomNumbers);

        Console.WriteLine($"Average: {results[0]:F2}, Min: {results[1]}, Max: {results[2]}");
    }

    static int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(1000, 10000); // Generates a 4-digit random number
        }

        return numbers;
    }

    static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }
}

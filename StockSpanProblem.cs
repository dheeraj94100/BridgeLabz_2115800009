using System;

class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        int[] stack = new int[n]; // Stack to store indices
        int top = -1; // Top pointer for stack

        for (int i = 0; i < n; i++)
        {
            // Pop elements from stack while stack is not empty and price at stack's top index is <= current price
            while (top >= 0 && prices[stack[top]] <= prices[i])
            {
                top--;
            }

            // Compute the span using if-else
            if (top == -1)
            {
                span[i] = i + 1; // All previous prices are smaller
            }
            else
            {
                span[i] = i - stack[top]; // Distance from the last higher price
            }

            // Push current index onto stack
            stack[++top] = i;
        }

        return span;
    }

    static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = CalculateSpan(prices);

        Console.WriteLine("Stock spans:");
        foreach (int s in span)
        {
            Console.Write(s + " ");
        }
    }
}

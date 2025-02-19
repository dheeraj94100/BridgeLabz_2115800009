using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> voteCounts = new Dictionary<string, int>(); // Stores candidate votes
        SortedDictionary<string, int> sortedResults; // Stores votes in sorted order
        LinkedList<string> voteOrder = new LinkedList<string>(); // Maintains voting order

        Console.Write("Enter the number of voters: ");
        int numVoters = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numVoters; i++)
        {
            Console.Write($"Enter candidate name for vote {i + 1}: ");
            string candidate = Console.ReadLine();

            // Track vote count
            if (voteCounts.ContainsKey(candidate))
                voteCounts[candidate]++;
            else
                voteCounts[candidate] = 1;

            // Maintain order of votes cast
            voteOrder.AddLast(candidate);
        }

        // Sort results alphabetically
        sortedResults = new SortedDictionary<string, int>(voteCounts);

        // Display voting order
        Console.WriteLine("\nVote Order:");
        foreach (var candidate in voteOrder)
        {
            Console.Write(candidate + " -> ");
        }
        Console.WriteLine("End\n");

        // Display final vote counts
        Console.WriteLine("Final Vote Results:");
        foreach (var kvp in sortedResults)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} votes");
        }

        // Display the winner(s)
        int maxVotes = voteCounts.Values.Max();
        var winners = voteCounts.Where(kvp => kvp.Value == maxVotes).Select(kvp => kvp.Key).ToList();

        Console.WriteLine($"\nWinner(s): {string.Join(", ", winners)} with {maxVotes} votes!");
    }
}

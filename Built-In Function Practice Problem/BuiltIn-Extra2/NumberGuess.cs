using System;

class NumberGuessingGame
{
    
    static void Main()
    {
        int low = 1, high = 100;
        string feedback = "";
        int guess = 0;

       
        Console.WriteLine("Think of a number between 1 and 100, and I'll try to guess it.");

        // Continue guessing until the correct number is found
        while (feedback != "correct")
        {
            guess = GenerateGuess(low, high); // Generate a random guess
            Console.WriteLine($"Is your number {guess}? (high, low, correct): ");
            feedback = Console.ReadLine().ToLower(); // Get user feedback

            // Adjust the range based on feedback
            if (feedback == "high")
                high = guess - 1;
            else if (feedback == "low")
                low = guess + 1;
        }

        // Output that the computer has guessed the number
        Console.WriteLine("I guessed your number!");
    }

    // Method to generate a random guess within the specified range
    static int GenerateGuess(int low, int high)
    {
        Random random = new Random();
        return random.Next(low, high + 1); // Return random number between low and high
    }
}

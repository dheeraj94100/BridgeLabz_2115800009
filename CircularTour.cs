using System;

class CircularTour
{
    public static int FindStart(int[] petrol, int[] distance)
    {
        int totalPetrol = 0;
        int totalDistance = 0;
        int currentPetrol = 0;
        int start = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            totalPetrol += petrol[i];
            totalDistance += distance[i];
            currentPetrol += petrol[i] - distance[i];

            // If we can't proceed from the current pump, reset the start point
            if (currentPetrol < 0)
            {
                // Set the next pump as the starting point
                start = i + 1;
                currentPetrol = 0;
            }
        }

        // If total petrol is less than total distance, there is no valid tour
        if (totalPetrol < totalDistance)
        {
            return -1; // No valid solution
        }

        return start; // Return the index of the starting pump
    }

    static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int start = FindStart(petrol, distance);

        if (start == -1)
        {
            Console.WriteLine("No valid starting point for the circular tour.");
        }
        else
        {
            Console.WriteLine("The tour can start at pump: " + start);
        }
    }
}

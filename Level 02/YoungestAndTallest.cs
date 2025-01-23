using System;

class YoungestAndTallestFriend
{
    static void Main()
    {
        // Taking user input for age and height of 3 friends
        Console.WriteLine("Enter the age and height of Amar");
        int ageAmar = Convert.ToInt32(Console.ReadLine());
        double heightAmar = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the age and height of Akbar");
        int ageAkbar = Convert.ToInt32(Console.ReadLine());
        double heightAkbar = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the age and height of Anthony");
        int ageAnthony = Convert.ToInt32(Console.ReadLine());
        double heightAnthony = Convert.ToDouble(Console.ReadLine());

        // Finding the youngest friend
        int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        if (youngestAge == ageAmar)
        {
            Console.WriteLine("The youngest friend is Amar");
        }
        else if (youngestAge == ageAkbar)
        {
            Console.WriteLine("The youngest friend is Akbar");
        }
        else
        {
            Console.WriteLine("The youngest friend is Anthony");
        }

        // Finding the tallest friend
        double tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
        if (tallestHeight == heightAmar)
        {
            Console.WriteLine("The tallest friend is Amar");
        }
        else if (tallestHeight == heightAkbar)
        {
            Console.WriteLine("The tallest friend is Akbar");
        }
        else
        {
            Console.WriteLine("The tallest friend is Anthony");
        }
    }
}
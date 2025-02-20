using System;
using System.IO;

class ReadUserInputFromConsole
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string favoriteLanguage = Console.ReadLine();

            string filePath = "UserData.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Programming Language: " + favoriteLanguage);
            }

            Console.WriteLine("User data has been saved to " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
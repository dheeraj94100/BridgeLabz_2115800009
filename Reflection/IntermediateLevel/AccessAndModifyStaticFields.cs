using System;
using System.Reflection;

public class Configuration
{
    private static string API_KEY = "initial_key";

    public static void PrintApiKey()
    {
        Console.WriteLine($"API_KEY: {API_KEY}");
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            // Print initial API_KEY value
            Configuration.PrintApiKey();

            // Use reflection to modify the private static field API_KEY
            Type configType = typeof(Configuration);
            FieldInfo apiKeyField = configType.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);
            if (apiKeyField != null)
            {
                apiKeyField.SetValue(null, "new_key_value");
            }

            // Print modified API_KEY value
            Configuration.PrintApiKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
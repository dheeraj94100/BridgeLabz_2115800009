using System;
using System.Reflection;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Apply the custom attribute to a class
[Author("Author Name")]
public class SampleClass
{
    public void Display()
    {
        Console.WriteLine("This is a method in SampleClass.");
    }
    // Class implementation
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Get the type of the class
            Type type = typeof(SampleClass);

            // Get the custom attributes of the class
            object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

            // Check if the attribute is applied to the class
            if (attributes.Length > 0)
            {
                // Retrieve and display the attribute value
                AuthorAttribute authorAttribute = (AuthorAttribute)attributes[0];
                Console.WriteLine("Author: " + authorAttribute.Name);
            }
            else
            {
                Console.WriteLine("The Author attribute is not applied to the class.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
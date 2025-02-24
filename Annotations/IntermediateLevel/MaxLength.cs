using System;
using System.Reflection;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

class User
{
    [MaxLength(10)] // Restrict Username length to 10 characters
    public string Username { get; }

    public User(string username)
    {
        ValidateMaxLength(this, nameof(Username), username);
        Username = username;
    }

    private void ValidateMaxLength(object obj, string fieldName, string value)
    {
        FieldInfo field = obj.GetType().GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
        var maxLengthAttr = field?.GetCustomAttribute<MaxLengthAttribute>();

        if (maxLengthAttr != null && value.Length > maxLengthAttr.Length)
        {
            throw new ArgumentException($"{fieldName} cannot exceed {maxLengthAttr.Length} characters.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            User user1 = new User("Alice"); // Valid username
            Console.WriteLine($"User created: {user1.Username}");

            User user2 = new User("VeryLongUsername"); // Will throw an exception
            Console.WriteLine($"User created: {user2.Username}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

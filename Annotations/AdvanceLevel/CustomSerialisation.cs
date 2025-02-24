using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

class User
{
    [JsonField("user_name")]
    public string Username { get; set; }

    [JsonField("email_address")]
    public string Email { get; set; }

    [JsonField("user_age")]
    public int Age { get; set; }

    public User(string username, string email, int age)
    {
        Username = username;
        Email = email;
        Age = age;
    }
}

class JsonSerializerCustom
{
    public static string SerializeToJson(object obj)
    {
        var jsonDict = new Dictionary<string, object>();

        foreach (PropertyInfo prop in obj.GetType().GetProperties())
        {
            var attribute = prop.GetCustomAttribute<JsonFieldAttribute>();
            string jsonKey = attribute != null ? attribute.Name : prop.Name;
            jsonDict[jsonKey] = prop.GetValue(obj);
        }

        return JsonSerializer.Serialize(jsonDict, new JsonSerializerOptions { WriteIndented = true });
    }
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User("Alice", "alice@example.com", 25);
        string json = JsonSerializerCustom.SerializeToJson(user);
        Console.WriteLine(json);
    }
}

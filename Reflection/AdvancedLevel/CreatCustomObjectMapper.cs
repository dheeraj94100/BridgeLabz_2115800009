using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T(); // Create an instance of the object
        Type type = typeof(T);

        foreach (var prop in properties)
        {
            FieldInfo field = type.GetField(prop.Key, BindingFlags.Public | BindingFlags.Instance);
            if (field != null)
            {
                object value = ConvertValue(field.FieldType, prop.Value);
                field.SetValue(obj, value);
            }
        }

        return obj;
    }

    private static object ConvertValue(Type type, object value)
    {
        if (value == null)
            return null;

        if (type.IsAssignableFrom(value.GetType()))
            return value;

        if (type.IsPrimitive || type == typeof(string))
            return Convert.ChangeType(value, type);

        if (typeof(IEnumerable).IsAssignableFrom(type) && value is IEnumerable<object> list)
        {
            Type elementType = type.GetGenericArguments().FirstOrDefault() ?? type.GetElementType();
            IList convertedList = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(elementType));

            foreach (var item in list)
                convertedList.Add(ConvertValue(elementType, item));

            return convertedList;
        }

        return Activator.CreateInstance(type); // Fallback to default instance if unsupported
    }
}

// Sample Class
public class Person
{
    public string Name;
    public int Age;
    public List<string> Hobbies;
}

// Testing the Custom Object Mapper
class Program
{
    static void Main()
    {
        Dictionary<string, object> properties = new Dictionary<string, object>
        {
            { "Name", "Alice" },
            { "Age", 25 },
            { "Hobbies", new List<object> { "Reading", "Cycling", "Hiking" } }
        };

        Person person = ObjectMapper.ToObject<Person>(properties);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Hobbies: {string.Join(", ", person.Hobbies)}");
    }
}

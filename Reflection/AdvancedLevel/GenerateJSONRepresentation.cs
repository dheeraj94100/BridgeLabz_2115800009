using System;
using System.Reflection;
using System.Text;

public class GenerateJSONRepresentation
{
    public static string ConvertToJson(object obj)
    {
        if (obj == null)
        {
            return "null";
        }

        StringBuilder jsonBuilder = new StringBuilder();
        Type objType = obj.GetType();
        jsonBuilder.Append("{");

        try
        {
            FieldInfo[] fields = objType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            for (int i = 0; i < fields.Length; i++)
            {
                FieldInfo field = fields[i];
                object fieldValue = field.GetValue(obj);
                jsonBuilder.AppendFormat("\"{0}\": \"{1}\"", field.Name, fieldValue);

                if (i < fields.Length - 1)
                {
                    jsonBuilder.Append(", ");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        jsonBuilder.Append("}");
        return jsonBuilder.ToString();
    }

    public static void Main(string[] args)
    {
        var exampleObject = new ExampleClass { Id = 1, Name = "Test" };
        string jsonString = ConvertToJson(exampleObject);
        Console.WriteLine(jsonString);
    }
}

public class ExampleClass
{
    public int Id;
    public string Name;
}

using System;
using System.Reflection;

class GetClassInformation
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the full class name (including namespace): ");
            string className = Console.ReadLine();

            Type type = Type.GetType(className);
            if (type == null)
            {
                Console.WriteLine("Class not found.");
                return;
            }

            Console.WriteLine($"Class: {type.FullName}");

            Console.WriteLine("\nMethods:");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("\nFields:");
            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
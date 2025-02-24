using System;
using System.Reflection;

public class Person
{
    private int age;

    public Person(int age)
    {
        this.age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Person person = new Person(25);

            // Get the type of the Person class
            Type personType = typeof(Person);

            // Get the private field 'age'
            FieldInfo ageField = personType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            if (ageField != null)
            {
                // Retrieve the value of the private field 'age'
                int ageValue = (int)ageField.GetValue(person);
                Console.WriteLine("Original Age: " + ageValue);

                // Modify the value of the private field 'age'
                ageField.SetValue(person, 30);

                // Retrieve the modified value of the private field 'age'
                ageValue = (int)ageField.GetValue(person);
                Console.WriteLine("Modified Age: " + ageValue);
            }
            else
            {
                Console.WriteLine("Field 'age' not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
using System;
using System.Reflection;

namespace DynamicallyCreateObjects
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
            Name = "Default Name";
            Age = 0;
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Get the type of the Student class
                Type studentType = typeof(Student);

                // Create an instance of the Student class using the default constructor
                object studentInstance = Activator.CreateInstance(studentType);

                // Cast the object to Student type
                Student student = studentInstance as Student;

                // Display the student information
                student?.DisplayInfo();
            }
            catch (MissingMethodException e)
            {
                Console.WriteLine("The constructor was not found: " + e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("The type is null: " + e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("The type is not a RuntimeType: " + e.Message);
            }
            catch (TargetInvocationException e)
            {
                Console.WriteLine("The constructor being called throws an exception: " + e.Message);
            }
            catch (MethodAccessException e)
            {
                Console.WriteLine("The caller does not have permission to call this constructor: " + e.Message);
            }
            catch (MemberAccessException e)
            {
                Console.WriteLine("Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism: " + e.Message);
            }
            catch (TypeLoadException e)
            {
                Console.WriteLine("The type cannot be loaded: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred: " + e.Message);
            }
        }
    }
}
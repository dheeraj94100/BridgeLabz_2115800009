using System;
using System.Reflection;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class SecureOperations
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Executing admin task...");
    }

    [RoleAllowed("USER")]
    public void UserTask()
    {
        Console.WriteLine("Executing user task...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string currentUserRole = "USER"; // Simulating a logged-in user with role "USER"

        SecureOperations operations = new SecureOperations();

        AttemptMethodExecution(operations, nameof(SecureOperations.AdminTask), currentUserRole);
        AttemptMethodExecution(operations, nameof(SecureOperations.UserTask), currentUserRole);
    }

    static void AttemptMethodExecution(object obj, string methodName, string userRole)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        var roleAttribute = method.GetCustomAttribute<RoleAllowedAttribute>();

        if (roleAttribute != null && roleAttribute.Role != userRole)
        {
            Console.WriteLine($"Access Denied! {userRole} cannot execute {methodName}.");
        }
        else
        {
            method.Invoke(obj, null);
        }
    }
}

using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello(string name);
}

public class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

public class LoggingProxy<T> : DispatchProxy
{
    private T _decorated;

    public static T Create(T decorated)
    {
        object proxy = Create<T, LoggingProxy<T>>();
        ((LoggingProxy<T>)proxy)._decorated = decorated;
        return (T)proxy;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        try
        {
            Console.WriteLine($"Method {targetMethod.Name} is being called");
            var result = targetMethod.Invoke(_decorated, args);
            return result;
        }
        catch (TargetInvocationException ex)
        {
            Console.WriteLine($"Exception in method {targetMethod.Name}: {ex.InnerException?.Message}");
            throw ex.InnerException;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IGreeting greeting = new Greeting();
        IGreeting proxy = LoggingProxy<IGreeting>.Create(greeting);

        proxy.SayHello("World");
    }
}
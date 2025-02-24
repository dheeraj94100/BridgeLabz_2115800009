using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Constructor)]
public class InjectAttribute : Attribute { }

public class DIContainer
{
    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T));
    }

    private object Resolve(Type type)
    {
        ConstructorInfo[] constructors = type.GetConstructors();

        foreach (var constructor in constructors)
        {
            if (constructor.GetCustomAttributes(typeof(InjectAttribute), false).Any())
            {
                try
                {
                    ParameterInfo[] parameters = constructor.GetParameters();
                    object[] parameterImplementations = new object[parameters.Length];

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        parameterImplementations[i] = Resolve(parameters[i].ParameterType);
                    }

                    return constructor.Invoke(parameterImplementations);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error resolving type {type.Name}: {ex.Message}");
                }
            }
        }

        throw new Exception($"No suitable constructor found for type {type.Name}");
    }
}

// Example classes
public class ServiceA
{
    public void DoWork() => Console.WriteLine("ServiceA is working");
}

public class ServiceB
{
    private readonly ServiceA _serviceA;

    [Inject]
    public ServiceB(ServiceA serviceA)
    {
        _serviceA = serviceA;
    }

    public void DoWork()
    {
        _serviceA.DoWork();
        Console.WriteLine("ServiceB is working");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DIContainer container = new DIContainer();
        try
        {
            ServiceB serviceB = container.Resolve<ServiceB>();
            serviceB.DoWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
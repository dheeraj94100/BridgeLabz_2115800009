using System;

public class Animal// Base class Animal with properties Name and Age, and a virtual method MakeSound
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
// Base class Animal with properties Name and Age, and a virtual method MakeSound
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog { Name = "Buddy", Age = 3 };// object of derived class is created
        Animal myCat = new Cat { Name = "Whiskers", Age = 2 };
        Animal myBird = new Bird { Name = "Tweety", Age = 1 };

        myDog.MakeSound();// method of derived class is called
        myCat.MakeSound();
        myBird.MakeSound();
    }
}
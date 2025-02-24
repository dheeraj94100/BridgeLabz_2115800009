using System;

class Animal
{
    // Base class method
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    // Overriding the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof! Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Dog
        Dog myDog = new Dog();
        
        // Calling the overridden method
        myDog.MakeSound();
    }
}

using System;

// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

// Derived class
public class Mammal : Animal
{
    public void Breathe()
    {
        Console.WriteLine("Breathing...");
    }
}

// Another derived class
public class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat();     // From base class
        myDog.Breathe(); // From intermediate class
        myDog.Bark();    // From derived class
    }
}


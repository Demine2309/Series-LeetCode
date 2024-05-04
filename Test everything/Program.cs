using System;

public class BaseClass
{
    public BaseClass()
    {
        Console.WriteLine("BaseClass constructor called.");
    }
}

public class DerivedClass : BaseClass
{
    public DerivedClass() : base()
    {
        Console.WriteLine("DerivedClass constructor called.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
    }
}


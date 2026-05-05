using System;

// Base Class
class Vehicle
{
    public Vehicle()
    {
        Console.WriteLine("Vehicle constructor");
    }

    public void Show()
    {
        Console.WriteLine("Vehicle method");
    }
}

// Derived Class
class Car : Vehicle
{
    public Car() : base()   // Calling base class constructor
    {
        Console.WriteLine("Car constructor");
    }

    public void Display()
    {
        base.Show();   // Calling base class method
        Console.WriteLine("Car method");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Car c = new Car();
//        c.Display();
//    }
//}
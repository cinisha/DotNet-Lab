using System;

// Base class
class Animal1
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class Dog
class Dog : Animal1
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Derived class Cat
class Cat : Animal1
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

//// Main class
//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal1 a;

//        a = new Dog();
//        a.MakeSound();

//        a = new Cat();
//        a.MakeSound();
//    }
//}
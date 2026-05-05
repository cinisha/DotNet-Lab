using System;

// SINGLE INHERITANCE
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats");
    }
}

// Dog inherits Animal (Single Inheritance)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

// MULTILEVEL INHERITANCE
// Puppy inherits Dog, which inherits Animal
class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy weeps");
    }
}

// HIERARCHICAL INHERITANCE
// Cat also inherits Animal
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat meows");
    }
}

//class Program
//{
//    static void Main()
//    {
//        // Single Inheritance
//        Console.WriteLine("Single Inheritance:");
//        Dog d = new Dog();
//        d.Eat();
//        d.Bark();

//        // Multilevel Inheritance
//        Console.WriteLine("\nMultilevel Inheritance:");
//        Puppy p = new Puppy();
//        p.Eat();
//        p.Bark();
//        p.Weep();

//        // Hierarchical Inheritance
//        Console.WriteLine("\nHierarchical Inheritance:");
//        Cat c = new Cat();
//        c.Eat();
//        c.Meow();
//    }
//}
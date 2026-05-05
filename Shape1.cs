using System;

// Abstract Class
abstract class Shape1
{
    public abstract void Draw();   // Abstract method
}

// Derived Class 1
class Circle1 : Shape1
{
    public override void Draw()
    {
        Console.WriteLine("Drawing circle");
    }
}

// Derived Class 2
class Triangle : Shape1
{
    public override void Draw()
    {
        Console.WriteLine("Drawing triangle");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Shape1 s;

//        s = new Circle1();
//        s.Draw();

//        s = new Triangle();
//        s.Draw();
//    }
//}
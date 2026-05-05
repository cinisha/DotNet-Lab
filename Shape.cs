using System;

// Base Class
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
}

// Derived Class 1
class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing square");
    }
}

// Derived Class 2
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing rectangle");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Shape s;

//        s = new Square();
//        s.Draw();

//        s = new Rectangle();
//        s.Draw();
//    }
//}
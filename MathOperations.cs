using System;

class MathOperations
{
    // Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Add two double values
    public double Add(double a, double b)
    {
        return a + b;
    }
}

//class Program
//{
//    static void Main()
//    {
//        MathOperations m = new MathOperations();

//        Console.WriteLine("Sum (2 int): " + m.Add(10, 20));
//        Console.WriteLine("Sum (3 int): " + m.Add(10, 20, 30));
//        Console.WriteLine("Sum (2 double): " + m.Add(5.5, 2.3));
//    }
//}
using System;

static class Calculator1
{
    // Static variables
    public static int a = 10;
    public static int b = 5;

    // Static method
    public static int Add()
    {
        return a + b;
    }

    public static int Subtract()
    {
        return a - b;
    }
}

//class Program
//{
//    static void Main()
//    {
//        // Accessing static members directly using class name
//        Console.WriteLine("a = " + Calculator.a);
//        Console.WriteLine("b = " + Calculator.b);

//        Console.WriteLine("Addition: " + Calculator.Add());
//        Console.WriteLine("Subtraction: " + Calculator.Subtract());
//    }
//}
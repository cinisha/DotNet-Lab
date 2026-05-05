using System;
class ArithmeticDemo
{
   public static void Lab3()
    {
        int a = 8;
        int b = 2;
        // Addition
        int sum = a + b;
        // Subtraction
        int difference = a - b;
        // Multiplication
        int product = a * b;
        // Division
        int quotient = a / b;
        // Modulus
        int remainder = a % b;

        Console.WriteLine("First number: " + a);
        Console.WriteLine("Second number: " + b);
       

        Console.WriteLine("Addition (+): " + sum);
        Console.WriteLine("Subtraction (-): " + difference);
        Console.WriteLine("Multiplication (*): " + product);
        Console.WriteLine("Division (/): " + quotient);
        Console.WriteLine("Modulus (%): " + remainder);

    }
}
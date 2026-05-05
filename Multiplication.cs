using System;

class Multiplication
{
    public static void lab10()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nMultiplication Table of " + num + ":");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}
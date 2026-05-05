using System;

class ArithmeticOperations
{
   public static void Lab4()
    {
        double num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;

        Console.WriteLine("\nResults:");
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Difference = " + difference);
        Console.WriteLine("Product = " + product);

        if (num2 != 0)
        {
            double division = num1 / num2;
            Console.WriteLine("Division = " + division);
        }
        else
        {
            Console.WriteLine("Division = Cannot divide by zero");
        }
    }
}

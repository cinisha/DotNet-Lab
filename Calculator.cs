using System;

class Calculator
{
    public static void Lab18()
    {
        // Accept two numbers
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Display menu
        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1 = Add");
        Console.WriteLine("2 = Subtract");
        Console.WriteLine("3 = Multiply");
        Console.WriteLine("4 = Divide");

        Console.Write("Enter your preference: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        double result;
        // Perform operation using switch
        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                }
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}

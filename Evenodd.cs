using System;
class EvenOdd
{
    public static void Lab7()
    {
        int num;
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("The number is Even");
        }
        else
        {
            Console.WriteLine("The number is Odd");
        }
    }
}
using System;
class SumNatural
{
   public static void Lab11()
    {
        int i = 1;
        int sum = 0;

        while (i <= 10)
        {
            sum += i;
            i++;
        }

        Console.WriteLine("Sum of first 10 natural numbers = " + sum);
    }
}

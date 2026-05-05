using System;

class CountNum
{
   public static void Lab12()
    {
        int num;
        int count = 0;

        do
        {
            Console.Write("Enter a number (0 to 100): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0)
            {
                count++;
            }

        } while (num != 0);

        Console.WriteLine("Total numbers entered (excluding 0) = " + count);
    }
}

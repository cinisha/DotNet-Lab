using System;
class BoxingUnboxing
{
   public static void Lab14()
    {
        // Boxing (int to object)
        int num = 55;
        object obj = num;   // Boxing happens here

        Console.WriteLine("Initial integer value: " + num);
        Console.WriteLine("Boxed object value: " + obj);

        // Unboxing (object to int)
        int unboxedNum = (int)obj;   // Explicit casting required
        Console.WriteLine("Unboxed integer value: " + unboxedNum);
    }
}
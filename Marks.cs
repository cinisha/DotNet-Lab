using System;

class Marks
{
   public static void Lab6()
    {
        double[] marks = new double[5];
        double total = 0, percentage;
        // Input marks
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter marks for subject " + (i + 1) + ": ");
            marks[i] = Convert.ToDouble(Console.ReadLine());
            total += marks[i];
        }
        // Calculate percentage
        percentage = total / 5;
        Console.WriteLine("\nTotal Marks = " + total);
        Console.WriteLine("Percentage = " + percentage + "%");
    }
}

using System;
class Circle
{
     public static void Lab5()
    {
        const double PI = 3.1416;
        double radius, area;

        Console.Write("Enter radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());
        area = PI * radius * radius;
        Console.WriteLine("Area of the circle = " + area);
    }
}

using System;

class Students
{
    int x;
    double y;

    public Students()
    {
        x = 0;
        y = 0.0;
        Console.WriteLine("Default ctor");
    }

    public Students(int a)
    {
        x = a;
        Console.WriteLine("Int ctor: x=" + x);
    }

    public Students(int a, double b)
    {
        x = a;
        y = b;
        Console.WriteLine("Int,Double ctor");
    }

    public Students(double b)
    {
        y = b;
        Console.WriteLine("Double ctor: y=" + y);
    }

    public void Show()
    {
        Console.WriteLine("x=" + x + ", y=" + y);
    }
}

//class Program
//{
//    static void Main()
//    {
//        Student s1 = new Student();
//        Student s2 = new Student(10);
//        Student s3 = new Student(5, 2.5);
//        Student s4 = new Student(3.14);

//        s1.Show();
//        s2.Show();
//        s3.Show();
//        s4.Show();
//    }
//}
using System;
class Demo
{
    int x;
    static int count;

    // Static Constructor (called once)
    static Demo()
    {
        count = 0;
        Console.WriteLine("Static Constructor Called");
    }
    // Default Constructor
    public Demo()
    {
        x = 0;
        count++;
        Console.WriteLine("Default Constructor Called. x = " + x);
    }
    // Parameterized Constructor
    public Demo(int val)
    {
        x = val;
        count++;
        Console.WriteLine("Parameterized Constructor Called. x = " + x);
    }
    // Method to display value
    public void Show()
    {
        Console.WriteLine("Value of x: " + x);
    }
    // Static Method
    public static void ShowCount()
    {
        Console.WriteLine("Total objects created: " + count);
    }
    // Destructor
    ~Demo()
    {
        Console.WriteLine("Destructor Called for object with x = " + x);
    }
}
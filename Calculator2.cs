using System;

class Calculator2
{
    public int value;

    // Constructor
    public Calculator2(int v)
    {
        value = v;
    }

    // Overloading + operator
    public static Calculator2 operator +(Calculator2 c1, Calculator2 c2)
    {
        return new Calculator2(c1.value + c2.value);
    }

    // Overloading == operator
    public static bool operator ==(Calculator2 c1, Calculator2 c2)
    {
        return c1.value == c2.value;
    }

    // Overloading != operator
    public static bool operator !=(Calculator2 c1, Calculator2 c2)
    {
        return c1.value != c2.value;
    }

    // Override Equals
    public override bool Equals(object obj)
    {
        Calculator2 c = obj as Calculator2;
        return this.value == c.value;
    }

    // Override GetHashCode
    public override int GetHashCode()
    {
        return value.GetHashCode();
    }
}

//class Program
//{
//    static void Main()
//    {
//        Calculator2 c1 = new Calculator2(10);
//        Calculator2 c2 = new Calculator2(20);
//        Calculator2 c3 = new Calculator2(10);

//        // Using + operator
//        Calculator2 result = c1 + c2;
//        Console.WriteLine("Sum: " + result.value);

//        // Using == operator
//        Console.WriteLine("c1 == c2: " + (c1 == c2));
//        Console.WriteLine("c1 == c3: " + (c1 == c3));
//    }
//}
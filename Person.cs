//using System;
//class Person
//{
//    private int age;
//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Age cannot be negative");
//            }
//            else
//            {
//                age = value;
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person();

//        p.Age = 25;   // valid
//        Console.WriteLine("Age: " + p.Age);

//        p.Age = -5;   // invalid
//        Console.WriteLine("Age: " + p.Age);
//    }
//}
using System;

class Person1
{
    string name;
    int age;

    // Method using 'this' keyword
    public void SetDetails(string name, int age)
    {
        this.name = name;   // refers to current object
        this.age = age;
    }

    public void Show()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person();

//        p.SetDetails("Ram", 25);
//        p.Show();
//    }
//}
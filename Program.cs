using College;
using System;
using System.Data;
using System.Drawing;

class Program
{
    public static void Main(string[] args)
    {
        //HelloBCA
        //Console.WriteLine("Hello, BCA");

        //Variables
        //Variables.Lab2();

        //ArithmeticDemo.Lab3();

        //ArithmeticOperations.Lab4();

        //Circle.Lab5();

        //Marks.Lab6();

        //EvenOdd.Lab7();

        //Day.Lab8();

        //NaturalNum.Lab9();

        //Multiplication.lab10();

        //SumNatural.Lab11();

        //CountNum.Lab12();

        //StringHandling.Lab13();

        //BoxingUnboxing.Lab14();

        //Enum.Lab15();

        //Studentinfo.Lab16();

        //Stdnamespace.Lab17();

        //Calculator.Lab18();

        //ConDemo d1 = new ConDemo();      // Default constructor
        //ConDemo d2 = new ConDemo(12);    // Parameterized constructor

        //d1.Show();
        //d2.Show();

        //ConDemo.ShowCount();

        //// Force destructor call (for demonstration only)
        //GC.Collect();
        //GC.WaitForPendingFinalizers();

        //Console.WriteLine("End of Main");



        //Students s1 = new Students();
        //Students s2 = new Students(10);
        //Students s3 = new Students(5, 2.5);
        //Students s4 = new Students(3.14);

        //s1.Show();
        //s2.Show();
        //s3.Show();
        //s4.Show();


        // Creating object and assigning values
        //Student s = new Student();
        //s.Name = "Sammy";
        //s.RollNo = 1;
        //s.Marks = 90;

        //// Printing values
        //Console.WriteLine("Name: " + s.Name);
        //Console.WriteLine("Roll No: " + s.RollNo);
        //Console.WriteLine("Marks: " + s.Marks);



        //Person p = new Person();

        //p.Age = 25;   // valid
        //Console.WriteLine("Age: " + p.Age);

        //p.Age = -5;   // invalid
        //Console.WriteLine("Age: " + p.Age);



        //Person1 p = new Person1();

        //p.SetDetails("Sammy", 25);
        //p.Show();



        //// Accessing static members directly using class name
        //Console.WriteLine("a = " + Calculator1.a);
        //Console.WriteLine("b = " + Calculator1.b);

        //Console.WriteLine("Addition: " + Calculator1.Add());
        //Console.WriteLine("Subtraction: " + Calculator1.Subtract());



        //// Single Inheritance
        //Console.WriteLine("Single Inheritance:");
        //Dog d = new Dog();
        //d.Eat();
        //d.Bark();

        //// Multilevel Inheritance
        //Console.WriteLine("\nMultilevel Inheritance:");
        //Puppy p = new Puppy();
        //p.Eat();
        //p.Bark();
        //p.Weep();

        //// Hierarchical Inheritance
        //Console.WriteLine("\nHierarchical Inheritance:");
        //Cat c = new Cat();
        //c.Eat();
        //c.Meow();



        //Professor p = new Professor();

        //p.Teach();
        //p.Research();



        //Car c = new Car();
        //c.Display();


        //Shape s;

        //s = new Square();
        //s.Draw();

        //s = new Rectangle();
        //s.Draw();


        //Shape1 s;

        //s = new Circle1();
        //s.Draw();

        //s = new Triangle();
        //s.Draw();


        //BaseClass1 obj1 = new BaseClass1();

        //Console.WriteLine(obj1.pub);
        //Console.WriteLine(obj1.inter);
        //Console.WriteLine(obj1.protInternal);

        ////Console.WriteLine(obj.prot);     // protected not accessible here
        ////Console.WriteLine(obj.priv);     // private not accessible here
        ////Console.WriteLine(obj.privProt); // not accessible here

        //DerivedClass1 d = new DerivedClass1();
        //d.ShowDerived();



        //Calculator2 c1 = new Calculator2(10);
        //Calculator2 c2 = new Calculator2(20);
        //Calculator2 c3 = new Calculator2(10);

        //// Using + operator
        //Calculator2 result = c1 + c2;
        //Console.WriteLine("Sum: " + result.value);

        //// Using == operator
        //Console.WriteLine("c1 == c2: " + (c1 == c2));
        //Console.WriteLine("c1 == c3: " + (c1 == c3));


        //MathOperations m = new MathOperations();

        //Console.WriteLine("Sum (2 int): " + m.Add(10, 20));
        //Console.WriteLine("Sum (3 int): " + m.Add(10, 20, 30));
        //Console.WriteLine("Sum (2 double): " + m.Add(5.5, 2.3));


        // Generic List
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);

        Console.WriteLine("List Elements:");
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

        // Generic Stack (LIFO)
        Stack<string> stack = new Stack<string>();
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Console.WriteLine("\nStack Elements:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        // Generic Queue (FIFO)
        Queue<double> queue = new Queue<double>();
        queue.Enqueue(1.1);
        queue.Enqueue(2.2);
        queue.Enqueue(3.3);

        Console.WriteLine("\nQueue Elements:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}

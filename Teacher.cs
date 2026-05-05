using System;

// Interface 1
interface Teacher
{
    void Teach();
}

// Interface 2
interface Researcher
{
    void Research();
}

// Class implementing multiple interfaces
class Professor : Teacher, Researcher
{
    public void Teach()
    {
        Console.WriteLine("Professor teaches students");
    }

    public void Research()
    {
        Console.WriteLine("Professor does research work");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Professor p = new Professor();

//        p.Teach();
//        p.Research();
//    }
//}

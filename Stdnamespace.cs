using System;
// Create namespace
namespace College
{
    public class Student
    {
        public string Name;
        public int RollNo;

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll No: " + RollNo);
        }
    }
}
// Accessing namespace from another class
class Stdnamespace
{
    public static void Lab17()
    {
        // Create object using namespace
        College.Student s = new College.Student();

        s.Name = "Sammy Adhikari";
        s.RollNo = 11;

        s.Display();
    }
}
using System;

// Define struct
struct Studentstruct
{
    public string Name;
    public int RollNo;
    public double Percentage;
}

class Studentinfo
{
    public static void Lab16()
    {
        // Create struct instance
        Studentstruct s;   

        // Assign values
        s.Name = "Sammy Adhikari";
        s.RollNo = 11;
        s.Percentage = 80.5;

        // Print details
        Console.WriteLine("Student Info:");
        Console.WriteLine("Name: " + s.Name);
        Console.WriteLine("Roll No: " + s.RollNo);
        Console.WriteLine("Percentage: " + s.Percentage);
    }
}
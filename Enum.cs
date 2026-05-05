using System;
// Declare enum
enum Months
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}
class Enum
{
   public static void Lab15()
    {
        // Assign enum value
        Months m = Months.April;

        // Print enum value
        Console.WriteLine("Month: " + m);

        // Print integer equivalent
        Console.WriteLine("Integer value of April: " + (int)m);
    }
}

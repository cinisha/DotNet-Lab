using System;
class StringHandling
{
   public static void Lab13()
    {
        string name = "Sammy";
        string message = "Hello Love";

        // 1. Uppercase and Lowercase
        Console.WriteLine("Original String: " + message);
        Console.WriteLine("Uppercase: " + message.ToUpper());
        Console.WriteLine("Lowercase: " + message.ToLower());

        // 2. String Length
        Console.WriteLine("Length of message: " + message.Length);

        // 3. Concatenation using + operator
        string concatPlus = "Hello " + name;
        Console.WriteLine("Using + operator: " + concatPlus);

        // 4. Using string.Concat()
        string concatMethod = string.Concat("Hello ", name);
        Console.WriteLine("Using string.Concat(): " + concatMethod);

        // 5. String Interpolation
        string interpolated = $"Hello {name}";
        Console.WriteLine("Using string interpolation: " + interpolated);
    }
}

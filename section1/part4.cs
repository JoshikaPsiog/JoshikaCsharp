using System;

class Program
{

    static void Main()
    {

        var a = 100;

        dynamic b = 100;

        b = "Hello";

        Console.WriteLine($"var a: {a}");

        Console.WriteLine($"dynamic b: {b}");

    }

}
using System;

public partial class Student
{
    partial void ShowDetails()
    {
        Console.WriteLine($"Marks: {Marks}");
    }
}


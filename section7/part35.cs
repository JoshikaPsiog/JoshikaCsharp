using System;
using System.Collections.Generic;
class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Student other)
    {
        return this.Age.CompareTo(other.Age);
    }

    public override string ToString() => $"{Name}, Age: {Age}";
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 22 },
            new Student { Name = "Bob", Age = 20 },
            new Student { Name = "Charlie", Age = 25 }
        };

        Console.WriteLine("Before Sorting:");
        students.ForEach(s => Console.WriteLine(s));

        students.Sort();

        Console.WriteLine("\nAfter Sorting by Age:");
        students.ForEach(s => Console.WriteLine(s));
    }
}

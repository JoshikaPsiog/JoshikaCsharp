using System;

class Student
{
    public const string CollegeName = "Sri Eshwar College";
    public readonly int RollNo;

    public Student(int rollNo)
    {
        RollNo = rollNo; 
    }

    public void Display()
    {
        Console.WriteLine($"College: {CollegeName}, Roll No: {RollNo}");
    }
}
class Program
{
    static void Main()
    {
        Student s1 = new Student(101);
        s1.Display();
        Student s2 = new Student(102);
        s2.Display();  
    }
}

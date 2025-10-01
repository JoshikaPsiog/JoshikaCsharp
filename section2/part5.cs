using System;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    public Student()
    {
        Id = 101;
        Name = "joshika";
        Marks = 540;
        Console.WriteLine("Default constructor called");
    }

    public Student(int id, string name) : this()
    {
        Id = id;
        Name = name;
        Console.WriteLine("Constructor with Id and Name called");
    }

    public Student(int id, string name, double marks) : this(id, name)
    {
        Marks = marks;
        Console.WriteLine("Constructor with Id, Name, and Marks called");
    }

    public void Display()  
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Marks: {Marks}");
    }

    public void Display(string message) 
    {
        Console.WriteLine($"{message} -> ID: {Id}, Name: {Name}, Marks: {Marks}");
    }

    public void Display(bool showMarksOnly) 
    {
        if (showMarksOnly)
            Console.WriteLine($"Marks: {Marks}");
        else
            Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Creating student s1:");
        Student s1 = new Student();
        s1.Display();                

        Console.WriteLine("\nCreating student s2:");
        Student s2 = new Student(101, "Joshika");
        s2.Display("Student Details");   

        Console.WriteLine("\nCreating student s3:");
        Student s3 = new Student(102, "Jaisree", 95.5);
        s3.Display(true);               
    }
}

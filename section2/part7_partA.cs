using System;

public partial class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }
    

    public Student(int id,string name,double marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
        ShowDetails();
    }
    partial void ShowDetails();

    //public void Display()
    //{
    //    Console.WriteLine($"ID: {Id}, Name: {Name}");

    //}
}


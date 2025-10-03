using System;

abstract class Shape
{
    public string Name { get; set; }
    public Shape(string name)
    {
        Name = name;
    }
    public abstract double CalculateArea();//defining but not initializing
    public void Display()
    {
        Console.WriteLine($"Calculating area of {Name}...");
    }
}
class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }
    public override double CalculateArea()  // must be called in derived class
    {
        return Math.PI * Radius * Radius;
    }
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height) : base("Rectangle")
    {
        Width = width;
        Height = height;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Shape c = new Circle(5);        
        c.Display();
        Console.WriteLine($"Area = {c.CalculateArea()}");

        Shape r = new Rectangle(4, 6); 
        r.Display();
        Console.WriteLine($"Area = {r.CalculateArea()}");
    }
}

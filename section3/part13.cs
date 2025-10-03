using System;

interface IShape
{
    double CalculateArea();
    void Display();
}
class Circle : IShape
{
    public double Radius;
    public Circle(double r) => Radius = r;//constructor
    public double CalculateArea() => Math.PI * Radius * Radius; 
    public void Display() => Console.WriteLine($"Circle area: {CalculateArea():F2}");
}
class Rectangle : IShape
{
    public double Width, Height;
    public Rectangle(double w, double h) { Width = w; Height = h; }

    public double CalculateArea() => Width * Height;

    public void Display() => Console.WriteLine($"Rectangle area: {CalculateArea():F2}");
}

class Program
{
    static void Main()
    {
        IShape c = new Circle(5);
        c.Display();

        IShape r = new Rectangle(4, 6);
        r.Display();
    }
}

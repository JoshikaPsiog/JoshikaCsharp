using System;
using System.Threading;
using System.Threading.Tasks;
interface IShape
{
    void Draw();
}
class Circle : IShape
{
    public void Draw() => Console.WriteLine("Drawing a Circle");
}
class Square : IShape
{
    public void Draw() => Console.WriteLine("Drawing a Square");
}
class ShapeFactory
{
    public static IShape GetShape(string type)
    {
        if (type.ToLower() == "circle")
            return new Circle();
        else if (type.ToLower() == "square")
            return new Square();
        else
            throw new ArgumentException("Unknown shape type");
    }
}
class Program
{
    static void Main()
    {
        IShape shape1 = ShapeFactory.GetShape("Circle");
        shape1.Draw();

        IShape shape2 = ShapeFactory.GetShape("Square");
        shape2.Draw();
    }
}
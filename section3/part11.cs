using System;

class Vehicle
{
    public string Name;   
    public Vehicle(string name)
    {
        Name = name;
    }
    public virtual void Drive()   
    {
        Console.WriteLine($"The vehicle {Name} is moving...");
    }
}
class Car : Vehicle
{
    public Car(string name) : base(name) { }
    public override void Drive()   
    {
        Console.WriteLine($"The car {Name} is driving on the road...");
    }
}
class SportsCar :Vehicle
{
    public SportsCar(string name) : base(name) { }
    public sealed override void Drive()   
    {
        Console.WriteLine($"The sports car {Name} is speeding on the highway...");
    }
}
class Program
{
    static void Main()
    {
        Vehicle v = new Vehicle("Generic Vehicle");
        v.Drive(); 
        Car c = new Car("Sedan");
        c.Drive();
        SportsCar sc = new SportsCar("Ferrari");
        sc.Drive();
    }
}

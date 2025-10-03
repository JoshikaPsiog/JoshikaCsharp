using System;
class vechicle {
	public int wheels;
	public string color;
	public vechicle(int wheels,string color){
		   this.wheels = wheels;
		this.color = color;
		}
}
class Bike : vechicle
{
	public bool hascarrier;
	public Bike(int wheels, string color,bool hascarrier) : base( wheels,color)
	{
		this.hascarrier = hascarrier;
		this.wheels=wheels;
		this.color=color;
	}
	public void demo()
	{
		Console.WriteLine($"wheels:{wheels}\n color:{color}\n carrier:{hascarrier}");
	}
}
class program { 
public static void Main()
	{
		// vechicle v = new vechicle();
		Bike b = new Bike(2, "Black",true);
		b.demo();
	}
}

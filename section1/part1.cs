//using System;   
//namespace ProjectA
//{
//	class Calculator
//	{
//		public void a()
//		{
//			Console.WriteLine("subtraction");
//		}
//	}
//}
//namespace ProjectB
//{
//	class Calculator
//	{
//		public void b()
//		{
//			Console.WriteLine("addition");
//		}
//	}
//}
//class Program
//{
//	static void Main()
//	{
//		ProjectA.Calculator calc1 = new ProjectA.Calculator();
//		ProjectB.Calculator calc2 = new ProjectB.Calculator();
//		calc1.a();
//		calc2.b();

//	}
//}



//using System; 
//class Program
//{
//	static void Main()
//	{
//		int age = 21;
//		string Name = "Joshika";
//		int num8 = 8;
//		double _salary = 50000;
//		Console.WriteLine($"Age: {age}\n Name: {Name}\n Salary: {_salary}\n Number:{num8}");
//	}

//}




#define DEBUG   

#define TEST 

 

#undef TEST

using System; 

namespace PreprocessorDemo
{

	class Program
	{

		static void Main(string[] args)
		{

			#region Startup Code 

			Console.WriteLine("Program Started");

			#endregion

#if (DEBUG)

			Console.WriteLine("Debug mode is ON");

#elif (TEST)

                Console.WriteLine("Test mode is ON"); 

#else

                Console.WriteLine("Release mode is ON"); 

#endif



#warning This is just a demo warning 

			Console.WriteLine("Program Ended");

		}

	}

}
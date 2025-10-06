//using System;
//class function
//{
//    public void demo()
//    {
//        int num = 100;
//        double d = num;   

//        Console.WriteLine(d);
//    }
//}
//class function_2
//{
//    public void demo()
//    {
//        double d = 9.78;
//        int i = (int)d;   

//        Console.WriteLine(i); 
//    }
//}
//class function_3
//{
//    public void demo()
//    {
//        object obj = "Hello World";
//        string str = obj as string; 

//        Console.WriteLine(str); 
//    }
//}
//class function_4
//{
//    public void demo()
//    {
//        object obj = "Joshika";
//        if (obj is string)   
//        {
//            Console.WriteLine("obj is a string");
//        }
//    }
//}
//class function_5
//{
//    public void demo()
//    {
//        string strNum = "123";
//        int num = Convert.ToInt32(strNum); 

//        Console.WriteLine(num + 1);
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        function ex1 = new function();
//        ex1.demo();

//        function_2 ex2 = new function_2();
//        ex2.demo();

//        function_3 ex3 = new function_3();
//        ex3.demo();

//        function_4 ex4 = new function_4();
//        ex4.demo();

//        function_5 ex5 = new function_5();
//        ex5.demo();
//    }
//}

using System; 

 class Value_types
{
    public void demo()
    {
        int x = 0;
        #region
        int? y = null; 

if (y.HasValue) 
            Console.WriteLine(y.Value); 
        else Console.WriteLine($"{x} value of x and y is null"); 
#endregion 
        Console.WriteLine();
    } 
} 

class Program
    {
        static void Main()
        {
            Value_types ex1 = new Value_types(); ex1.demo(); int? z = null; int result = z ?? -1;

            // null-coalescing operator Console.WriteLine(result);  

        }
    } 
using System;

class function
{
    public void demo()
    {
        int num = 100;
        double d = num;   // Implicit conversion

        Console.WriteLine(d); // 100
    }
}

class function_2
{
    public void demo()
    {
        double d = 9.78;
        int i = (int)d;   // Explicit conversion (casting)

        Console.WriteLine(i); // 9
    }
}

class function_3
{
    public void demo()
    {
        object obj = "Hello World";
        string str = obj as string;  // "as" operator

        Console.WriteLine(str); // Hello World
    }
}

class function_4
{
    public void demo()
    {
        object obj = "Joshika";
        if (obj is string)    // "is" operator
        {
            Console.WriteLine("obj is a string");
        }
    }
}

class function_5
{
    public void demo()
    {
        string strNum = "123";
        int num = Convert.ToInt32(strNum); // Using Convert class

        Console.WriteLine(num + 1); // 124
    }
}

class Program
{
    public static void Main()
    {
        function ex1 = new function();
        ex1.demo();

        function_2 ex2 = new function_2();
        ex2.demo();

        function_3 ex3 = new function_3();
        ex3.demo();

        function_4 ex4 = new function_4();
        ex4.demo();

        function_5 ex5 = new function_5();
        ex5.demo();
    }
}

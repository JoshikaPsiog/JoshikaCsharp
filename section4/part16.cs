using System;
delegate int maths(int a, int b);
class program { 
    static int add(int a, int b)=>a+b;
    static int sub(int a, int b)=>a-b;
    static int mul(int a, int b)=>a*b;
    public static void Main()
    {
        maths op;
        op = add;
        Console.WriteLine("add="+ op(5, 2));
        op = sub;
        Console.WriteLine("sub="+ op(5, 2));
        op = mul;
        Console.WriteLine("mul="+ op(5, 2));
    }
}
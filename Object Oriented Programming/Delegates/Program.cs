using System;
delegate void Calculator(int x, int y);
class Program
{
    public static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public static void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    public static void Main(string[] args)
    {
        Calculator obj = new Calculator(Add);
        obj += Sub; //multicast Delegates
        obj(5, 9);
    }
    
}
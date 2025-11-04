/*3) Write a program to demonstrate the basics of class and object.*/
using System;
class Program
{
    int a, b;
    public Program(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public void Add()
    {
        int c = a + b;
        Console.WriteLine("The sum is " + c);
    }
    public static void Main(string[] args)
    {
        Program obj = new Program(5, 6);
        obj.Add();

       
    }
}
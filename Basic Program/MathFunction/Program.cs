// checking two main method in the C# programs

using System;
class A
{
    public static void Main(string[] args)
    {
        Double x = 5.0;
        double y;
        y = Math.Sqrt(x);
        Console.WriteLine("Sqrt of {0} is {1}", x, y);

    }
}

class B
{
    public static void Main(string[] args)
    {
        decimal a = 55.5M;
        decimal b;
        b = Math.Floor(a);
        Console.WriteLine("The floor value of {0} is {1}", a, b);
    }
}



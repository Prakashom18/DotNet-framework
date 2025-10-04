using System;
class Boxing
{
    public static void Main()
    {
        int a = 10,b;
        object o;
        o = a;
        Console.WriteLine("Implicit conversion {0}", o);
        b = (int)o;
        Console.WriteLine(b);
        
    }
}
using System;
class Program
{

    [Obsolete("This is old Method use new method")]
    public static void OldMethod()
    {
        Console.WriteLine("This is an old Method");
    }
    public static void NewMethod()
    {
        Console.WriteLine("This is new method");
    }
    public static void Main(string[] args)
    {
        OldMethod();// gives warning
        NewMethod();
    }
}
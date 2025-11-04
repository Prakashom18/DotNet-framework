// use of the base class
using System;
class baseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Overriding");
    }

}
class DerivedClass : baseClass
{
    public override void Print()
    {
        base.Print();
        Console.WriteLine("OverLoads");
    }

}
class Program
{
    public static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.Print();
    }
}
using System;
using System.Runtime.CompilerServices;
class BaseClass
{
    public virtual void Base1()
    {
        Console.WriteLine("This is the base class and can be override");

    }
}
class Derived1 : BaseClass
{
    public override void Base1()
    {
        Console.WriteLine("THis is the dervied class ");

    }
}

class Derived2 : Derived1
{
    public sealed override void Base1()
    {
        Console.WriteLine("this is the sealed method and cannt be overriden now");

    }
}
class Der3 : Derived2
{
    // public override void Base1()
    // {
    //     Console.WriteLine("this is the test for overriding of the method in this case");
    // }
    public static void Main(string[] args)
    {
        Der3 obj = new Der3();
        obj.Base1();
    }
}


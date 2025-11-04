using System;
class BaseClass
{
    public void Display()
    {
        Console.WriteLine("Base CLass");
    }

}
class DerivedCLass : BaseClass
{
    public new void Display()
    {
        Console.WriteLine("Derived CLass");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        DerivedCLass obj = new DerivedCLass();
        obj.Display();
    }
}
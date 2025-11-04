using System;
using System.Runtime;
using System.Runtime.InteropServices;
public class AttAttribute : Attribute
{
    public string name { get; }
    public int age { get; set; }
    public AttAttribute(string Name)
    {
        name = Name;
    }
}

[Att("This is test for positional attribute", age = 10)] // for the class with the same namespace
class TestClass
{
    [Att("this is for the method")]  //target attributes => for the method
    public void sum()
    {
        Console.WriteLine("This needs to be replaced");
    }

}

class Program
{
    public static void Main(string[] args)
    {
        TestClass t = new TestClass();
        t.sum();
    }
}
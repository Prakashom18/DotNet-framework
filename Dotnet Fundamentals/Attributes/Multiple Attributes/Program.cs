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

[Serializable]  /*=> the class is ready to be converted into the bytes and sent over network  or stored in the file and database*/
[Att("This is test for positional attribute", age = 10)]
class TestClass
{
    [Att("this is for the method")]  
    public void sum()
    {
        Console.WriteLine("Multiple Attributes is used here");
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
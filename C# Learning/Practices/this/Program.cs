// use of the base class
using System;
class baseClass
{
    private string name { get; set; }
    private int roll { get; set; }
    internal baseClass(string name, int roll)
    {
     this.name  = name;
    this.roll = roll;
    }
    internal void Display()
    {
        Console.WriteLine("Your name is " + name);
        Console.WriteLine("Your roll is" + roll);
    }


}
class Program
{
    internal static void Main()
    {
        baseClass o = new baseClass("Hari",15);
        o.Display();
       
    }
}
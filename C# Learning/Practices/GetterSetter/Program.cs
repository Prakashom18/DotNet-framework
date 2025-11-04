using System;
using System.Reflection;
class A
{
    private string name;
    private int roll;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name cannot be empty");
            }
        }
    }

    public int Roll
    {
        get
        {
            return roll;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("ROll cannot be negative");
            }
            else
            {
                roll = value;
            }
        }
    }
   


}
class Program
{
    internal static void Main(string[] args)
    {
        A o = new A();
        o.Name = "hari";
        o.Roll = 15;
        Console.WriteLine("your name is " + o.Name);
        Console.WriteLine("Your roll is" + o.Roll);
        
    }
}
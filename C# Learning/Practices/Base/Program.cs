using System.ComponentModel.Design.Serialization;

class A
{
    public int a = 10;
    public void Prog()
    {
        Console.WriteLine("The use of base");
    }
    public A(string name){
        Console.WriteLine("The name is "+name);
    }

}
class B : A
{
    public B(string name) : base(name)
    {
        Console.WriteLine("Base Class" + name);
    }
   public void derived()
    {
        base.Prog();
        Console.WriteLine("the use of base a "+base.a);
       
        Console.WriteLine("Base keyword is used");
    }

}
class Program
{
    public static void Main(string[] args)
    {
        B obj = new B("Om Prakash");
        obj.derived();
        
        
    }

}
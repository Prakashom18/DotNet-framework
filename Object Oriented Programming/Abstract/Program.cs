using System;
public abstract class A
{
    public abstract void M1();
    public void M2()
    {
        Console.WriteLine("Hello Abstract");
    }
}
class C : A
{
    public override void M1()
    {
        Console.WriteLine("this is implementation");
       
    }
    public static void Main(String[] Args)
    {
        C obj = new C();
        obj.M1();
        obj.M2();

        
    }
}
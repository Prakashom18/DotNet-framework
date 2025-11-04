 class A
{
    public int a=5, b=10;

    public void Add()
    {
        Console.WriteLine("Sum is " + (a + b));

    }
}
class B : A
{
    public void Sub()
    {
        Console.WriteLine("Diff is " + (a - b));
    }
}

class C : A
{ 
    public void Mult()
    {
        Console.WriteLine("The mul value is" + (a * b));
    }
    
}
class Program
{
    public static void Main(string[] args)
    {
        B obj = new B();
        obj.Add();
        obj.Sub();

        C obj1 = new C();
        obj1.Add();
        obj1.Mult();
    

    }
}
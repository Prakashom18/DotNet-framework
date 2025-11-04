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

class C : B
{
    public void Mult()
    {
        Console.WriteLine("Mult is", +(a * b));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        C obj = new C();
        obj.Add();
        obj.Sub();
        obj.Mult();

    }
}
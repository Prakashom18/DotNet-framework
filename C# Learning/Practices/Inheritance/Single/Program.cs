 class A
{
    public int a=5, b=10;

    private void Add()
    {
        Console.WriteLine("Sum is " + (a + b));

    }
}
 class B : A
{
    private  void Sub()
    {
         Console.WriteLine("Diff is " + (a - b));
    }
}
class Program
{
    public static void Main(string[] args)
    {
        B obj = new B();
        obj.Add();
        obj.Sub();

    }
}
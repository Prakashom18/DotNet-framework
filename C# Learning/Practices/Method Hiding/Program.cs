class A
{
    public  void Display()
    {
        Console.WriteLine("this needs to be over riden");
    }
class B : A
{
    public new void Display()
    {
        Console.WriteLine("This overrides the above function");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        B obj = new B();
        obj.Display();
    }
}
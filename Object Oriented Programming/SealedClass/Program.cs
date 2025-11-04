using System;
sealed class A
{
    public void sum()
    {
        Console.WriteLine("Sum is operation");
    }
}
class C : A
{
    public static void Main(String[] args)
    {
        C obj = new C();
        obj.sum();
    }
}
//throws and error message of Sealed class cannot be inherited

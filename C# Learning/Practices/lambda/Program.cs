class A
{
    delegate int del(int i);
    public static void Main(string[] args)
    {
        del Square = y => y * y;
        int j = Square(5);
        Console.Write(j);
    }
}
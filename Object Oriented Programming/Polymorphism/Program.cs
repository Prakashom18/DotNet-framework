using System;
 class Polymorphism
{
    int x, y, z;

    public Polymorphism(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public int Add()
    {
        return x + y + z;
    }
    public int Add(int x , int y)
    {
        return x + y;

    }
    public int Add(int x, int y, int z)
    {
        return x + y + z;
    }
    public static void Main(string[] args)
    {
        Polymorphism obj = new Polymorphism(5, 6, 7);
        Console.WriteLine(obj.Add());
        Console.WriteLine(obj.Add(5, 6));
         Console.WriteLine(obj.Add(8, 6,7));

    }
}
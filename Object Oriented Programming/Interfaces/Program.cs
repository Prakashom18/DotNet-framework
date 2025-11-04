using System;

interface Addition
{
    int Add(); // method signature
}

interface Multiplication
{
    int Mul(); // method signature
}

class Compute : Addition, Multiplication
{
    int x, y;

    public Compute(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int Add()
    {
        return x + y;
    }

    public int Mul()
    {
        return x * y;
    }

    public static void Main(string[] args)
    {
        Compute Ans = new Compute(5, 3); // pass values
        Console.WriteLine("Addition: " + Ans.Add());
        Console.WriteLine("Multiplication: " + Ans.Mul());
    }
}

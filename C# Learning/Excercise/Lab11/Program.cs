using System;

interface OPShape
{
    double OPGetArea();
}

class OPCircle : OPShape
{
    public double radius = 5;
    public double OPGetArea() => Math.PI * radius * radius;
}

class OPSquare : OPShape
{
    public double side = 4;
    public double OPGetArea() => side * side;
}

class Program
{
    static void Main()
    {
        OPShape shape;

        shape = new OPCircle();
        Console.WriteLine("Circle Area: " + shape.OPGetArea());

        shape = new OPSquare();
        Console.WriteLine("Square Area: " + shape.OPGetArea());
    }
}

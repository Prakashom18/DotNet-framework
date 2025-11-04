using System;
class Construct
{
    private int a;
    private int b;
    public Construct(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
        public static void Main(String[] args)
    {
        Construct obj = new Construct(8,5); //when the object is created the Constructor automatically invokes
        Console.WriteLine("This is the constrcutor" + obj.a + obj.b);
    }

}
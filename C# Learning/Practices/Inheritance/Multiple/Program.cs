//  class A
// {
//     public int a=5, b=10;

//     public void Add()
//     {
//         Console.WriteLine("Sum is " + (a + b));

//     }
// }
// class B
// {
//     public void Sub()
//     {
//         Console.WriteLine("Diff is " + (a - b));
//     }
// }

// class C : B, A
// {
//     public void Mult()
//     {
//         Console.WriteLine("The mult is " + (a * b));
//     }

// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         C obj = new C();
//         obj.Add();
//         obj.Sub();

//     }
// }

interface IHerviborous
{
    public void Veg();
}

interface ICarnivorous
{
    public void  Non_Veg();
}

class Omnivorous : IHerviborous, ICarnivorous
{
    public void Veg()
    {
        Console.WriteLine("Eats veg");
    }
    public void Non_Veg()
    {
        Console.WriteLine("Eats non veg");
    }
    public void Both()
    {
        Console.WriteLine("It is both");
    }
}
 
class Program
{
    public static void Main()
    {
        Omnivorous obj = new Omnivorous();
        obj.Veg();
        obj.Non_Veg();
        obj.Both();
        
      
    }
}


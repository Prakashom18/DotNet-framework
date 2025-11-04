using System;
namespace Multilevel_Inheritance
{
    class Add
    {
       public int a, b, c;
       public Add()
        {
            Console.WriteLine("Enter a and b");
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
        }
        public void add()
        {
            c = a + b;
            Console.WriteLine("Subtraction "+ c);
        }
    }
    class Sub : Add
    {
        public void sub()
        {
            c = a - b;
            Console.WriteLine("Multiplication is "+ c);
        }

    }


    class Mult : Sub
    {
        public void mult()
        {
            c = a * b;
            Console.WriteLine("Multiplication is " + c);
        }


    }
    
    class Program
    {
        public static void Main()
        {
            Mult obj = new Mult();
            obj.add();
            obj.sub();
            obj.mult();
            
        }
    }
    
}
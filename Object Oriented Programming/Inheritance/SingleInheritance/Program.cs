using System;
using System.Net.Http.Headers;
namespace I
{
    class Add
    {
      public  int a, b, c;

         public Add()
        {
            Console.WriteLine("Enter the values of a and b");
            string input1 = Console.ReadLine();
             a = Convert.ToInt32(input1);
            string input2 = Console.ReadLine();
            b = Convert.ToInt32(input2);

        }
        public void add()
        {
            c = a + b;
            Console.WriteLine("The sum is" + c);
        }

    }
    class Sub : Add
    {
        public void mult()
        {
            c = a * b;
            Console.WriteLine("the multiplication is " + c);
        }

        public static void Main(string[] args)
        {
            Sub obj = new Sub();
            obj.add();
            obj.mult();

        }
    }
}
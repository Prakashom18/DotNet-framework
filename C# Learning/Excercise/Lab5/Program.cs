/*Write a program to implement multiple inheritance with the use of interfaces.*/

using System;
namespace lab
{
    interface Add
    {
         int add();
    }
    interface Sub
    {
         int sub();
    }
    class Compute : Add, Sub
    {
        public int a=5, b=10;

        public int add()
        {
            return a + b;

        }
        public int sub()
        {
            return a - b;
        }

        public static void Main(string[] args)
        {
              Compute obj = new Compute();
            Console.WriteLine("Addition: " + obj.add());
            Console.WriteLine("Subtraction: " + obj.sub());
        }
      
    }
}
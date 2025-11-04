using System;
namespace Heirarchial_Inheritance
{
    class A
    {
        
        public void print()
        {
            Console.WriteLine("Heirarchial_Inheritance");
        }
    }
    class B : A
    {
        public void second()
        {
            Console.WriteLine("1st Inheritance");
        }
    }
    class C : A
    {
        public void third()
        {
            Console.WriteLine("2nd Inheritance");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            B obj1 = new B();
             obj1.print();
            obj1.second();


            C obj2 = new C();
             obj2.print();
            obj2.third();
           

        }
    }
}
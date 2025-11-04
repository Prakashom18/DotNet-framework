using System;
namespace MethodOverriding
{
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("This is a base class");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Display()
        {
          
            Console.WriteLine("This is a derived class");

        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            BaseClass obj = new DerivedClass();
            obj.Display();
            
        }
    }


}
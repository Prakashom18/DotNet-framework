using System;
using System.Security.Cryptography.X509Certificates;
namespace Inheritance
{
    interface Veg
    {
        void Eat();
    }
    interface NonVeg
    {
        void Eat1();
    }
    class Vegan : Veg, NonVeg
    {
        public void Eat()
        {
            Console.WriteLine("Eats vegetables and fruits only");
        }
        public void Eat1()
        {
            Console.WriteLine("Eats meats");
        }

    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Vegan obj = new Vegan();
            obj.Eat();
            obj.Eat1();
        }
    }
}
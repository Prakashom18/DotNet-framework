using System;
namespace Inheritance
{
    class A
    {
        int roll, age;
       public A(int age, int roll)
        {
            this.age = age;
            this.roll = roll;

        }
        public void display()
        {
            Console.WriteLine("Roll is" + this.roll + "Age is" + this.age);

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            A obj = new A(5, 15);
            obj.display();
        }
    }
}
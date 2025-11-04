using System;
namespace Lab
{
    class Encapsulation
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
                else
                {
                    name = "unknown";
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 1;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("THe name is " + name);
            Console.WriteLine("The age is " + age);
        }


    }
    class Program
    {
        public static void Main(String[] args)
        {
            Encapsulation obj = new Encapsulation();
            obj.Name = "Bishal";
            obj.Age = 15;
            Encapsulation obj1 = new Encapsulation();
            obj.Name = "hero";
            obj.Age = 50;
            obj.Display();
            obj1.Display();

        }
       
    }
}
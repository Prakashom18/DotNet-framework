using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int age;
            age = 28;
            if (age > 18)
            {
               Console.WriteLine("You are eligible to vote.",age);
            }
            else
            {
               Console.WriteLine("You are not eligible to vote.",age);
            }
            long population = 7800000000;
            Console.WriteLine(population);
            double negative = -55.2;
            Console.WriteLine(negative);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            string name = "Om";
            char letter = 'G';
            Console.WriteLine(name);
            Console.WriteLine(letter);
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.ReadLine();

            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("hello" +name);

            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            int checkAge = Convert.ToInt32(age);
            Type intType = age.GetType();
            Console.Write(intType);
            Console.WriteLine("THe age is:" + age);

            Console.Write("enter the day");
            string input  = Console.ReadLine();
            int day = Convert.ToInt32(input);
            switch (day)
            {
                case 1: Console.WriteLine("Sunday");
                    break;

                case 2: Console.WriteLine("Monday");
                    break;
             case 3: Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thrusday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }



        }
    }
}

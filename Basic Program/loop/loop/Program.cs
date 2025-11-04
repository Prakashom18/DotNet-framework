using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use of for loop");
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i * 5);
            }

            Console.WriteLine("Use of while loop");
            i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i * 5);
                i++;
            }
            int a = 1;
            Console.WriteLine("Use of do while loop");
            do
            {
                Console.WriteLine(a * 5);
                a++;
            } while (a <= 5);

            Console.WriteLine("Use of foreach loop");
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("User Input");
            string input = Console.ReadLine();
            int c = Convert.ToInt32(input);

            Console.WriteLine("Use of for loop");
            int b;
            for (b = 0; b < c; b++)
            {
                Console.WriteLine(b + " * 5 = " +b * 5);
            }

            //similar pattern for all loops


        }
    }
}

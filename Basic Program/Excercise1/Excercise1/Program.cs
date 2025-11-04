using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to print the multiplication");
            string input = Console.ReadLine();
            int.TryParse(input, out int result);
            // int result = Convert.ToInt32(input); can be used
            for(int i =1; i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", result, i, result * i);

            }
        }
    }
}

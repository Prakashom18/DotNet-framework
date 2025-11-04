using System;
using System.Globalization;
namespace BoxUnbox
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 100;
            object obj = a;
            Console.WriteLine(obj);

            int unbox = (int)obj;
            Console.WriteLine("unbox value is {0}", unbox);
            
        }
    }
}
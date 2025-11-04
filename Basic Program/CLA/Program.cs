using System;
namespace A
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Argument length" + args.Length);
            Console.WriteLine("Supplied Arguments are");
            foreach(Object obj in args)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
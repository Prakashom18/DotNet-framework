using System;
namespace Apple
{
    class Index
    {
        private string[] apple = { "John", "Shyam", "Hari" };
        public string this[int index]
        {
            get
            {
                return apple[index];
            }
            set
            {
                apple[index] = value;

            }
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Index obj = new Index();
            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
        }
    }
}
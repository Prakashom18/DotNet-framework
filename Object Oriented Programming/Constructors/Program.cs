using System;
namespace Constructor
{
    class Constructor
    {
        int num;

        public void check()
        {
            int a = 5;
            this.num = a;
            Console.WriteLine("this is default constructor");
            Console.WriteLine(num);
        }
        public static void Main(string[] args)
        {
            Constructor C = new Constructor();
            C.check();
        }

    }
}


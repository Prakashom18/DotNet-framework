using System;
using System.Dynamic;
namespace Indexer
{
    class Indexer
    {
        private string[] names = new string[10];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
        public static void Main(string[] args)
        {
            Indexer obj = new Indexer();
            obj[0] = "Hari";
            obj[1] = "Shyam";
            Console.WriteLine(obj[0]);
        }
    }
}
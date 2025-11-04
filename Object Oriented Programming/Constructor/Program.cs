using System;
namespace ClassObject
{
    class Mobile
    {
        int cost;
        string model = "";

        string color = "";

        public void Calling()
        {
            Console.WriteLine("Voice Call");
        }

        public void Messaging()
        {
            Console.WriteLine("Text Msg");
        }

        public void Music()
        {
            Console.WriteLine("Song ..");
        }

        public static void Main(string[] args)
        {
            Mobile m = new Mobile();
            m.Calling();
            m.Messaging();

            m.cost = 1000;
            m.model = "Realme 5i";
            m.color = "Green";
            Console.WriteLine(m.cost);
            Console.WriteLine(m.model);
            Console.WriteLine(m.color);
        }
    }
 }   

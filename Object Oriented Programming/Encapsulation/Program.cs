using System;
using System.ComponentModel;
namespace Encap
{
    class Encapsulation
    {
        private int atmpin;

        public int getReturn()
        {
            return atmpin;

        }
        public void setValue(int pin)
        {
            atmpin = pin;
           
        }
    }
    class B
    {
        
        public static void Main(string[] args)
        {
            Encapsulation obj = new Encapsulation();
            obj.setValue(5000);
            Console.WriteLine("ATM pin "+obj.getReturn());
            

            
        }
    }
}
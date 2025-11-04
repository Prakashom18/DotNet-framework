using System;
namespace ClassObject
{
    class Pradeep
    {
        // public void Display()
        // {
        //     Console.WriteLine("Fake Classical Player");
        // }

        // public static void Main(string[] args)
        // {
        //     Pradeep objName = new Pradeep();// className ObjName = new ClassName();
        //     objName.Display();
        // }

        private int age;   //age is field 
        public int Age //property
        {
            get
            {
                return age; //returns age = 10
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("AGe should be greater than 0");
                }
                else
                {
                    age = value;// age = 10
                    
                }
                
            }
        }
        public static void Main(string[] args)
        {
            Pradeep objName = new Pradeep();// className ObjName = new ClassName();
            objName.Age = -11;
            Console.WriteLine("get and set" + objName.Age);
            
        }
                



    }
    
}
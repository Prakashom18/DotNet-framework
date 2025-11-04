
using System;
namespace parametrizedConstructor
{
    class parametrizedConstructor
    {
       

        parametrizedConstructor(int age , string name)
        {
            Console.WriteLine("Age  is " + age);
            Console.WriteLine("the name is", name);

        }
     public static void Main(string[] args)
        {
            parametrizedConstructor obj = new parametrizedConstructor(50,"Hari ");
            

        }
   
   
    }
   




}
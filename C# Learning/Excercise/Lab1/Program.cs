// Write a program to convert input strings from lower to upper and upper to lower
// case.
using System;
namespace lab1
{
    class UL
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower to be changed into UpperCase");
            string input = Console.ReadLine();
            string Upper = input.ToUpper();
            Console.WriteLine("UpperCase" + Upper);

            Console.WriteLine("Enter the UpperCase to be changed into lower");
            string input1 = Console.ReadLine();
            string Lower = input1.ToLower();
             Console.WriteLine("Lower Case"+ Lower);

        }
        
    }
}
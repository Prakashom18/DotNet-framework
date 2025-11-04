/*Write a program to create a new string from a given string where first and last
characters will be interchanged.*/
using System;
namespace Lab2
{
    class Program
    {
        public static void Main(String[] args)
        {
            string input = Console.ReadLine();
            int a = input.Length;
            char  firstChar = input[0];
            char lastChar = input[a-1];
            string middleChar = input.Substring(1, a - 2);

            string final = lastChar + middleChar + firstChar;
            Console.WriteLine("The changes is " +  final);
            
        }
        
    }
}
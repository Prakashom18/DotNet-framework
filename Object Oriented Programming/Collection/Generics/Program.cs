using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<int> lst = new List<int>();
        lst.Add(1);
        lst.Add(2);
        lst.Add(3);

        List<string> str = new List<string>();
        str.Add("Hi");
        str.Add("Hello");
        str.Add("Welcome");

        Hashtable hash = new Hashtable();
        hash.Add("Number", 1);
        hash.Add("Car", "Ferrari");

      
        Console.WriteLine("Integer List:");
        foreach (int i in lst)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nString List:");
        foreach (string s in str)
        {
            Console.WriteLine(s);
        }

       
        Console.WriteLine("\nHashtable:");
        foreach (DictionaryEntry entry in hash)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}

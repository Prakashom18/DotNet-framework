using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList arraylist;
        arraylist = new ArrayList();
        arraylist.Add(1);
        arraylist.Add("happy");
        arraylist.Remove(33);
        Console.WriteLine(arraylist.Count);
    }
}
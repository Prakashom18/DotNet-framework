//Implementation of the array list
using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        ArrayList arr = new ArrayList();

        arr.Add(10);
        arr.Add("Hello");
        arr.Add(3.14);

        arr.AddRange(new int[] { 1, 2, 3 });
        arr.Insert(1, "Inserted");
        arr.InsertRange(2, new string[] { "Apple", "Banana" });

        Console.WriteLine("Elements in ArrayList:");
        foreach (var item in arr)
            Console.Write(item + " ");
        Console.WriteLine();

        arr.Remove("Hello");
        arr.RemoveAt(0);
        arr.RemoveRange(1, 2);

        Console.WriteLine("\nAfter removal:");
        foreach (var item in arr)
            Console.Write(item + " ");
        Console.WriteLine();

        Console.WriteLine("\nContains Banana? " + arr.Contains("Banana"));
        Console.WriteLine("Index of Apple: " + arr.IndexOf("Apple"));

        arr.Reverse();
        Console.WriteLine("\nAfter Reverse:");
        foreach (var item in arr)
            Console.Write(item + " ");
        Console.WriteLine();

        arr.Sort(); // works only if same type
        Console.WriteLine("\nAfter Sort (if numeric):");
        foreach (var item in arr)
            Console.Write(item + " ");
        Console.WriteLine();

        Console.WriteLine("\nCount: " + arr.Count);
        Console.WriteLine("Capacity: " + arr.Capacity);
    }
}

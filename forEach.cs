using System;

class ForeachLoopExample
{
    public static void Main()
    {
        string[] fruits = { "Apple", "Banana", "Cherry" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }
    }
}

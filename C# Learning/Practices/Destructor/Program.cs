using System;

class OPExample
{
    public OPExample()
    {
        Console.WriteLine("Object Created");
    }

    ~OPExample()
    {
        Console.WriteLine("Object Destroyed");
    }
}

class Program
{
    static void Main()
    {
        CreateObject();
        Console.WriteLine("Main method completed");

        // Force garbage collection
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("End of program");
    }

    static void CreateObject()
    {
        OPExample obj = new OPExample();
    }
}

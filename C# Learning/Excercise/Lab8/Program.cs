using System;

delegate void OPMessageDelegate(string message);

class Program
{
    static void OPPrintMessage(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    static void Main()
    {
        OPMessageDelegate del = new OPMessageDelegate(OPPrintMessage);
        del("Hello from delegate!");
    }
}

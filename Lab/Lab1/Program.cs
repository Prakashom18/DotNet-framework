using System;

class Program
{
    static void Main(string[] args)
    {
            // Display a simple message
        Console.WriteLine("Hello World.");

        // Display command-line arguments
        Console.WriteLine("Command Line arguments:");

        if (args.Length == 0)
        {
            Console.WriteLine("No arguments passed.");
        }
        else
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i + 1}: {args[i]}");
            }
        }
    }
}

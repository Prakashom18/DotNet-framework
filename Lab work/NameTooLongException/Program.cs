using System;

// Custom Exception Class
public class NameTooLongException : Exception
{
    public NameTooLongException() : base("Name is too long") { }
    public NameTooLongException(string message) : base(message) { }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        try
        {
            if (name.Length > 12)
            {
                throw new NameTooLongException();
            }

            Console.WriteLine("Your name is: " + name);
        }
        catch (NameTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

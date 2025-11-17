using System;

public class Program
{
    public static void Main()
    {
        string[] countries = { "Nepal", "India", "China", "USA","Germany"};

        Console.WriteLine("List of Countries:");

        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }
    }
}

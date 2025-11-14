using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine(num + " is neither prime nor composite.");
            return;
        }

        int count = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }

        if (count == 2)
            Console.WriteLine(num + " is a Prime number.");
        else
            Console.WriteLine(num + " is a Composite number.");
    }
}

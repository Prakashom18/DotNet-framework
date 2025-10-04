using System;

class MultipleIf
{
    public static void Main()
    {
        int a = 30;

        if (a % 3 == 0 && a % 5 == 0 && a % 7 == 0)
        {
            Console.WriteLine("Number is divisible by 3, 5, and 7");
        }
        else if (a % 3 == 0 && a % 5 == 0)
        {
            Console.WriteLine("Number is divisible by 3 and 5");
        }
        else if (a % 3 == 0)
        {
            Console.WriteLine("Number is divisible by 3 only");
        }
        else
        {
            Console.WriteLine("Number is not divisible by 3, 5, or 7");
        }
    }
}

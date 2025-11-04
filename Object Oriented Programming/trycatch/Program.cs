using System;

class TryCatchExample
{
    public static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;  // ⚠️ This will throw an exception
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}

using System;
using System.IO.Pipelines;
using System.Linq.Expressions;
class Program
{
    public static void Main(String[] args)
    {
        try
        {
            int a = 11;
            int b = 0;
            int result = a / b;
            Console.WriteLine("Result" + result);

        }
        catch (Exception e)
        {
            Console.WriteLine("Error" + e.Message);
        }
        finally
        {
            Console.WriteLine("Program Completed");

        }
        try
        {
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine("result" + arr[5]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error occured: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Program COmpleted");
        }
    }
    
}
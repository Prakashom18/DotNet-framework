using System;
enum Days
{
    Sunday, Monday, Tuesday, Wednesday, THrusday, Friday, Saturday
}
class Imp
{
    public static void Main(string[] args)
    {
        Days today = Days.Wednesday;
        Console.WriteLine(today);
        Console.WriteLine((int)today);
    }
}
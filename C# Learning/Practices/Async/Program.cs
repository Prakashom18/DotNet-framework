using System;
using System.ComponentModel;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Task started");
        await DoWorkAsync();
        await Work();
        Console.WriteLine("task Completed");
    }
    static async Task DoWorkAsync()
    {
        await Task.Delay(5000);
        Console.WriteLine("Working Inside async method");
    }
    static async Task Work()
    {
        await Task.Delay(2000);
        Console.WriteLine("Task 2 completed");
    }
}
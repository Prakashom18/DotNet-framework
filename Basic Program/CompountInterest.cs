using System;

class CompoundInterest
{
    static void Main()
    {
        Console.WriteLine("Compound Interest Calculator");
        Console.WriteLine("----------------------------");

        // Taking user inputs
        Console.Write("Enter Principal amount (P): ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Annual Interest Rate (R) in %: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (T) in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number of times interest applied per year (N): ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Calculating Compound Interest
        double amount = principal * Math.Pow((1 + (rate / (100 * n))), n * time);
        double compoundInterest = amount - principal;

        // Display results
        Console.WriteLine($"\nTotal Amount (A): {amount:F2}");
        Console.WriteLine($"Compound Interest: {compoundInterest:F2}");
    }
}

using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Simple C# Calculator ---");

        // 1. Get the first number
        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return; // Exit if input is bad
        }

        // 2. Get the operator
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // 3. Get the second number
        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return; // Exit if input is bad
        }
        
        // Variable to hold the result
        double result = 0;

        // 4. Perform calculation based on the operator
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return; // Exit on division error
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator entered.");
                return; // Exit on invalid operator
        }

        // 5. Display the result
        Console.WriteLine($"\nResult: {num1} {op} {num2} = {result}");
    }
}

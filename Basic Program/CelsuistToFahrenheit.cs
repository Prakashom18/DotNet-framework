using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("---------------------");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());
        double result = 0;

        if (choice == 1)
        {
            result = (temp * 9 / 5) + 32;
            Console.WriteLine($"{temp}°C = {result}°F");
        }
        else if (choice == 2)
        {
            result = (temp - 32) * 5 / 9;
            Console.WriteLine($"{temp}°F = {result}°C");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}

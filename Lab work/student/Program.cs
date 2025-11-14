using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "student.txt";

        // Input student details
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your semester: ");
        string semester = Console.ReadLine();

        // Write details to file
        StreamWriter writer = new StreamWriter(fileName);
        writer.WriteLine(name);
        writer.WriteLine(semester);
        writer.Close();

        Console.WriteLine("\nStudent information saved!\n");

        // Read details from file
        Console.WriteLine("Student Details from file:");
        StreamReader reader = new StreamReader(fileName);
        Console.WriteLine("Name: " + reader.ReadLine());
        Console.WriteLine("Semester: " + reader.ReadLine());
        reader.Close();
    }
}

using System;
public class AttAttribute : Attribute // Attribute Class
{
    public string message;
    public AttAttribute(string msg)
    {
        message = msg;
    }
}

[Att("This is an attribute class program")]
class Student
{
    public void Display()
    {
        Console.WriteLine("This is the student class method");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student s = new Student();
        s.Display();
    }
}


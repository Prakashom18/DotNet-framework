using System;

// Abstract class 1
public abstract class Employee
{
    public abstract void Project();
    public void Role()
    {
        Console.WriteLine("Engineer");
    }
}

// Abstract class 2
public abstract class Employee1
{
    public abstract void Project1();
    public void Role1()
    {
        Console.WriteLine("Doctor");
    }
}

// Derived class from Employee
public class EngineerEmployee : Employee
{
    public override void Project()
    {
        Console.WriteLine("Working on a Software Development Project.");
    }
}

// Derived class from Employee1
public class DoctorEmployee : Employee1
{
    public override void Project1()
    {
        Console.WriteLine("Working on a Medical Research Project.");
    }
}

// Main Program
class Program
{
    public static void Main()
    {
        // Create Engineer object
        EngineerEmployee eng = new EngineerEmployee();
        Console.WriteLine("--- Engineer Details ---");
        eng.Role();
        eng.Project();

        // Create Doctor object
        DoctorEmployee doc = new DoctorEmployee();
        Console.WriteLine("\n--- Doctor Details ---");
        doc.Role1();
        doc.Project1();
    }
}

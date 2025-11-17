using System;

class Employee
{
    // (a) Field members
    private string firstName;
    private string lastName;
    private double salary;

    // (b) Properties
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FullName
    {
        get { return firstName + " " + lastName; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    // (c) Parameterized constructor
    public Employee(string fName, string lName, double sal)
    {
        firstName = fName;
        lastName = lName;
        salary = sal;
    }

    // (d) Method to increment salary
    public void IncrementSalary(double s)
    {
        salary += salary * s / 100;
    }

    // (d) Display method
    public void Display()
    {
        Console.WriteLine("Full Name: " + FullName);
        Console.WriteLine("Salary: " + salary);
    }
}

class Program
{
    static void Main()
    {
        // (e & f) Create object e1 using constructor
        Employee e1 = new Employee("Joh", "Rat", 50000);

        // (g) Display Full Name and Salary using properties
        Console.WriteLine("Using properties:");
        Console.WriteLine("Full Name: " + e1.FullName);
        Console.WriteLine("Salary: " + e1.Salary);

        // (h) Change First Name
        e1.FirstName = "Mike";

        // (i) Increment salary by 10%
        e1.IncrementSalary(10);

        // (j) Display Full Name and Salary using Display method
        Console.WriteLine("\nAfter update:");
        e1.Display();
    }
}

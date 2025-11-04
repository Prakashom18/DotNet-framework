using System;

class OPStudent
{
    private string OPName;
    private int OPRoll;

    // Constructor
    public OPStudent(string name, int roll)
    {
        OPName = name;
        OPRoll = roll;
    }

    // Property
    public string OPStudentName
    {
        get { return OPName; }
        set { OPName = value; }
    }

    public void OPDisplay()
    {
        Console.WriteLine($"Name: {OPName}, Roll: {OPRoll}");
    }
}

class Program
{
    static void Main()
    {
        OPStudent s1 = new OPStudent("Bishal", 10);
        s1.OPDisplay();
    }
}

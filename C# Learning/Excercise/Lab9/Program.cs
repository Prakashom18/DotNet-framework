using System;

class OPParent
{
    public virtual void OPShow()
    {
        Console.WriteLine("Parent class method");
    }
}

class OPChild : OPParent
{
    public new void OPShow()  // Method Hiding
    {
        Console.WriteLine("Child class hidden method");
    }
}

class OPChildOverride : OPParent
{
    public override void OPShow()  // Method Overriding
    {
        Console.WriteLine("Child class overridden method");
    }
}

class Program
{
    static void Main()
    {
        OPParent p1 = new OPChild();
        p1.OPShow(); // Parent method (hiding)

        OPParent p2 = new OPChildOverride();
        p2.OPShow(); // Child method (overriding)
    }
}

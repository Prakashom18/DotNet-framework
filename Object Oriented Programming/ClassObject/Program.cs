using System.Runtime.CompilerServices;

class Mobile
{
    int price;
    String storage="";
    String color="";

    public void Calling()
    {
        Console.WriteLine("voice message");
    }

    public void Chatting()
    {
        Console.WriteLine("Text Message");
    }

    public void Music()
    {
        Console.WriteLine("Song...");

    }
    static void Main(string[] args)
    {
        Mobile mob = new Mobile();
        mob.price = 10000;
        mob.storage = "8gb ram";
        mob.color = "Green";
        Console.WriteLine(mob.price);
        Console.WriteLine(mob.storage);
        Console.WriteLine(mob.color);

        mob.Calling();
        mob.Chatting();
        mob.Music();



    }
}
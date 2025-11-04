using System.Reflection.Metadata;

class Program
{
    private string[] names = new string[10];
    public string this[int i]
    {
        get
        {
            return names[i];
        }
        set
        {
            names[i] = value;

        }
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        p[0] = "hari ";
        p[1] = "Pode";
        Console.WriteLine($"The first name is {p[0]} and second name is {p[1]}",p[0], p[1]);
        
        
    } 
}
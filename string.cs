using System;
class Program
{
    public static void Main()
    {
        string username = "apple";
        string passwd = "12345";
        if (username.Equals("apple") && passwd.Equals("12345"))
        {
            Console.WriteLine("Logged in");
        }
        else
        {
            Console.WriteLine("Login failed");
        }
    }
}
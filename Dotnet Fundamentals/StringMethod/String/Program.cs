using System;
class A
{
    public static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = s1; // copying string
        Console.WriteLine(s2);
        string s3 = string.Concat(s1, s2);
        Console.WriteLine(s3);
        Console.WriteLine(string.Equals(s1, s2));
        Console.WriteLine(string.Compare(s1, s3));
        Console.WriteLine(s3.IndexOf("e"));
        Console.WriteLine("Uppercase: " + s3.ToUpper());
        Console.WriteLine("Lowercase:" + s3.ToLower());
        Console.WriteLine(s3.Replace("H", "J"));
        Console.WriteLine(s3.Contains("lo"));
        string s4 = s1.Insert(3, "app");
        string s5 = "HelloWorld";
        string part1 = s5.Substring(5);
        Console.WriteLine("Substring from index 5: " + part1);
        Console.WriteLine(s5.Substring(3, 4));

        

    }
}
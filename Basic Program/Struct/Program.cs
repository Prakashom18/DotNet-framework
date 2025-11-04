using System;
struct Persons
{
    public string name;
    public int age;
    public int roll;
}
class A
{
    public static void Main(string[] args)
    {
        Persons Person1;
        Person1.name = "Hari";
        Person1.age = 20;
        Person1.roll = 14;
        Console.WriteLine("Name is {0} \nAge is {1}\n Roll is {2}",Person1.name, Person1.age,Person1.roll);
    }

}
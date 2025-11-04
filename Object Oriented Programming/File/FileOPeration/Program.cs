using System;
using SystemIO;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"E:\dotnet\VS CODE\Object Oriented Programming\File\FileOPeration";
        FileStream fs = new FileStream(path, FileMode.Create);
        byte[] data = Encoding.UTF8.GetBytes("Hello From FIlestream");
        fs.Write(data, 0, data.Length);

        FileInfo info = new FileInfo(path);
        Console.WriteLine("File Name" + info.Name);
        Console.WriteLine("File Exists", info.Exists);

        File.AppendAllBytes(path, "Added using FileClasses");
        Console.WriteLine("\n FIle content using file classes");
        Console.WriteLine(File.ReadAllText(path));

        

    }
    
}
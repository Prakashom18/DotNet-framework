using System;
using System.IO;

class file_eg
{
    public static void Main(string[] args)
    {
        // Correct file path on your desktop
        string path = @"C:\Users\Acer\OneDrive\Desktop\a.txt";

        // Create and write one byte (66 = 'B')
        FileStream fw = new FileStream(path, FileMode.Create);
        fw.WriteByte(66); // Writes character 'B'
        fw.Close();

        // Open again for reading
        FileStream fr = new FileStream(path, FileMode.Open);
        int r;
        while ((r = fr.ReadByte()) != -1)
        {
            Console.Write((char)r); // Displays the character
        }
        fr.Close();

        Console.WriteLine("\nFile created successfully at: " + path);
    }
}

using System;
class ODA
{
    public static void Main(string[] args)
    {
        int[,] D2 = new int[3, 4];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                D2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Two dimensional array");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(D2[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
}
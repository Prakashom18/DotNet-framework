using System;
class ODA
{
    public static void Main(string[] args)
    {
        int[][] jagged = new int[2][];
        jagged[0] = new int[2];
        jagged[1] = new int[3];
        Console.WriteLine("Array input"); 
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] = Convert.ToInt32(Console.ReadLine());

            }
        }
        Console.WriteLine("Print");
         for(int i = 0; i< jagged.Length; i++)
        {
            for(int j = 0; j < jagged[i].Length; j++)
            {
                Console.WriteLine(jagged[i][j]);
                
            }
        }

    }
}
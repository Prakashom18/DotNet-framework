using System;
class ODA
{
    public static void Main(string[] args)
    {
        int[] number = new int[5];
        number[0] = 5;
        number[1] = 2;
        Console.WriteLine(number[0]);
        Console.WriteLine(number[1]);

        int[] nums = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter array elemtent");
            nums[i] = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("array elements are");
          for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(nums[i]);

        }
    }
}
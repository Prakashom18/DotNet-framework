using System;
class Switch_case
{
    public static void Main()
    {
        char ch = 'X';
        switch (ch)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("Vowels");
                break;
            default:
                Console.WriteLine("Consonent");
                break;


        }
    }
}
using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Input number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Input p: ");
        int position = int.Parse(Console.ReadLine());
        num = (num >> position) & 1;
        Console.WriteLine("Bit at p == 1?");
        if(num == 1)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}
using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Input number:");
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine("Input p:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Input v:");
        byte v = byte.Parse(Console.ReadLine());
        long mask, result = 0;
        if(v==1)
        {
            mask = 1 << position;
            result = num | mask;
        }
        else
        {
            mask = ~(1 << position);
            result = num & mask;
        }
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(8, '0'));
        Console.WriteLine("Result:");
        Console.WriteLine(result);
    }
}
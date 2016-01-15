using System;

class ExtractBitNumberThree
{
    static void Main()
    {
        Console.Write("Input number: ");
        int num = int.Parse(Console.ReadLine());
        num = (num >> 3) & 1;
        Console.Write("Bit #3: ");
        Console.WriteLine(num);
    }
}
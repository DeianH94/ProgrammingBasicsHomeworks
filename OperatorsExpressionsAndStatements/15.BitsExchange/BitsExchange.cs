using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint num = uint.Parse(Console.ReadLine());
        num = ((~(7u << 24 | 7u << 3)) & num) | (((num & (7u << 3)) << 21) | ((num & (7u << 24)) >> 21));
        Console.WriteLine("Result: " + num);
    }
}
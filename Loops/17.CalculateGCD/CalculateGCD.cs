using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("GCD({0}, {1})", a, b);
        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine(a);
    }
}
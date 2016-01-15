using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Console.Write("Input n!: ");
        int n = int.Parse(Console.ReadLine());
        int k = 1;
        BigInteger result = 1;
        int countZeros = 1;
        while(Math.Pow(5, k) <= n)
        {
            k++;
        }
        for(int i = 1; i <= k; i++)
        {
            countZeros += (n / ((int)Math.Pow(5, i)));
        }
        Console.WriteLine("Traling zeros of {0}! = {1}", n, countZeros - 1);
    }
}
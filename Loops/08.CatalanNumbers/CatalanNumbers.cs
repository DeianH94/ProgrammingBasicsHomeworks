using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial1 = 1;
        BigInteger factorial2 = 1;
        BigInteger factorial3 = 1;
        if (0 <= n && n < 100)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                factorial1 *= i;
            }
            for (int i = 1; i <= 1 + n; i++)
            {
                factorial2 *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                factorial3 *= i;
            }
            BigInteger result = factorial1 / (factorial2 * factorial3);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}
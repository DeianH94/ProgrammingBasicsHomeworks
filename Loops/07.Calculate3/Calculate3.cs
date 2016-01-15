using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input k:");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        BigInteger factorielNK = 1;
        BigInteger result = 0;
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                if (i <= k)
                {
                    factorielK *= i;
                }
                if (i <= (n - k))
                {
                    factorielNK *= i;
                }
            }
            result = factorielN / (factorielK * factorielNK);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}
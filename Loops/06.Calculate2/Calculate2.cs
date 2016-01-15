using System;

class Calculate2
{
    static void Main()
    {
        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input k:");
        int k = int.Parse(Console.ReadLine());
        decimal factorialN = 1;
        decimal factorialK = 1;
        decimal delenie = 0;
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
                delenie = factorialN / factorialK;
            }
            Console.WriteLine(delenie);
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}
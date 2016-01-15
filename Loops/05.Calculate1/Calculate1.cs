using System;

class Calculate1
{
    static void Main()
    {
        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input x:");
        int x = int.Parse(Console.ReadLine());
        decimal factoriel = 1;
        decimal result = 1;
        decimal sum = 1;
        for(int i = 0; i < n; i++)
        {
            factoriel *= i + 1;
            result *= x;
            decimal delenie = factoriel / result;
            sum = sum + delenie;
        }
        Console.WriteLine("Sum = {0:0.00000}", sum);
    }
}
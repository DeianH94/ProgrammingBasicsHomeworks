using System;

class SumOfNNumbers
{
    static void Main()
    {
        double b, sum = 0;
        int a = int.Parse(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {
            b = double.Parse(Console.ReadLine());
            sum = sum + b;
        }
        Console.WriteLine(sum);
    }
}
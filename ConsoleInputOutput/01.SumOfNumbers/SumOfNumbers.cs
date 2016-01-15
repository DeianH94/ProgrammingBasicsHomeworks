using System;

class SumOfNumbers
{
    static void Main()
    {
        double a, b, c, sum;
        Console.Write("Input first number: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Input third number: ");
        c = double.Parse(Console.ReadLine());
        sum = a + b + c;
        Console.WriteLine("Sum = {0:0.##}", sum);
    }
}
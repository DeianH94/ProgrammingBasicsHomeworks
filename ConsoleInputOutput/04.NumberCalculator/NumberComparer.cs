using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Input first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(a, b));
    }
}
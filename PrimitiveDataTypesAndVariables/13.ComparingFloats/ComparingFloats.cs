using System;

class ComparingFloats
{
    static void Main()
    {
        double a, b, eps = 0.000001;
        Console.WriteLine("Input first number:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Input second number:");
        b = double.Parse(Console.ReadLine());
        if (Math.Abs(a - b) < eps)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}

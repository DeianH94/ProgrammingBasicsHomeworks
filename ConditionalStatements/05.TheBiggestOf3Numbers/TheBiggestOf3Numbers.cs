using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double max;
        Console.Write("Input a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Biggest: ");
        if (a > b)
        {
            max = a;
        }
        else
        {
            max = b;
        }
        if (max > c)
        {
            Console.WriteLine(max);
        }
        else
        {
            Console.WriteLine(c);
        }
        //Short variant
        //Console.WriteLine(Math.Max(Math.Max(a, b), c));
    }
}
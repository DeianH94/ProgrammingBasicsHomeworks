using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Input a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Input d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Input e: ");
        double e = double.Parse(Console.ReadLine());
        Console.WriteLine("Biggest:");
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b);
        }
        else if (c >= b && c >= a && c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d >= b && d >= c && d >= a && a >= e)
        {
            Console.WriteLine(d);
        }
        else if (e >= b && e >= c && e >= d && e >= a)
        {
            Console.WriteLine(e);
        }
    }
}
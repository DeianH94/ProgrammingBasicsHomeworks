using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.Write("Input a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input c: ");
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            else
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
        else
        {
            if (c > b)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
            else if (a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
        }
    }
}
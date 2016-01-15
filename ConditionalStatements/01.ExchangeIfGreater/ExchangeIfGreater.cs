using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Input a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b: ");
        double b = double.Parse(Console.ReadLine());
        double temp;
        if(b > a)
        {
            temp = b;
            b = a;
            a = temp;
        }
        Console.WriteLine("Result: " + a + " " + b);
    }
}
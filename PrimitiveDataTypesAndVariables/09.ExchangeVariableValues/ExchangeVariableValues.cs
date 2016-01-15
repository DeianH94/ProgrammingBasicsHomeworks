using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine("Before:");
        Console.WriteLine(a);
        Console.WriteLine(b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After");
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

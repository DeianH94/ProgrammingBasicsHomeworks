using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Input number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Odd?");
        if(n % 2 == 0)
            Console.WriteLine(false);
        else
            Console.WriteLine(true);
    }
}
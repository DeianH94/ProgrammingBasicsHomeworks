using System;

class FibonacciNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int sum = 1;
        int last = 0;
        int before;
        Console.WriteLine(0);
        for(int i = 1; i < a; i++)
        {
            before = sum;
            sum = sum + last;
            last = before;
            Console.WriteLine(sum + " ");
        }
    }
}
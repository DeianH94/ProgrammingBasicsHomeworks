using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Input number");
        int num = int.Parse(Console.ReadLine());
        int check = 0;
        for (int i = 2; i < num; i++)
            if (num % i == 0)
                check++;
        Console.WriteLine("Prime?");
        if(check > 0 || num <= 1)
            Console.WriteLine(false);
        else
            Console.WriteLine(true);
    }
}
﻿using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Input int number: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i <= n / 2; i++)
        {
            string top = new String('\'', n - i) + new String('^', 1 + 2 * i) + new String('\'', n - i);
            Console.WriteLine(top);
        }
        for (int i = 0; i <= n / 2; i++)
        {
            string middle = new String('\'', n - 1 - i) + new String('^', 3 + 2 * i) + new String('\'', n - 1 - i);
            Console.WriteLine(middle);
        }
        for(int i = 0; i <= n / 2; i++)
        {
            string bottom = new String('\'', n - 1) + "| |" + new String('\'', n - 1);
            Console.WriteLine(bottom);
        }
        string ground = new String('-', 2 * n + 1);
        Console.WriteLine(ground);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CurrencyCheck
{
    static void Main(string[] args)
    {
        double rubles = double.Parse(Console.ReadLine());
        double dollars = double.Parse(Console.ReadLine());
        double euro = double.Parse(Console.ReadLine());
        double levaB = double.Parse(Console.ReadLine());
        double levaM = double.Parse(Console.ReadLine());
        rubles = (rubles / 100) * 3.5;
        dollars = dollars * 1.5;
        euro = euro * 1.95;
        levaB = levaB / 2;
        double min = rubles;
        if(dollars < min)
        {
            min = dollars;
        }
        if (euro < min)
        {
            min = euro;
        }
        if (levaB < min)
        {
            min = levaB;
        }
        if (levaM < min)
        {
            min = levaM;
        }
        Console.WriteLine("{0:0.00}", min);
    }
}
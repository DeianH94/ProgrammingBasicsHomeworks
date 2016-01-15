using System;

class MultiplicationSign
{
    static void Main()
    {
        bool positive = true;
        Console.Write("Input a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Result: ");
        if (a < 0)
        {
            positive = false;
            if (b < 0)
            {
                positive = true;
                if (c < 0)
                {
                    positive = false;
                }
            }
        }
        else if (b < 0)
        {
            positive = false;
            if (c < 0)
            {
                positive = true;
            }
        }
        else if (c < 0)
        {
            positive = false;
        }
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else if (positive)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Input side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input height h: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("Area: {0:0.#######}", area);
    }
}
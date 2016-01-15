using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Input width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Input height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = width * 2 + height * 2;
        double area = width * height;
        Console.WriteLine("Perimeter: {0:0.#}", perimeter);
        Console.WriteLine("Area: {0:0.#}", area);
    }
}
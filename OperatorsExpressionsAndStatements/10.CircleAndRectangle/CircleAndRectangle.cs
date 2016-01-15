using System;

class CircleAndRectangle
{
    static void Main()
    {
        Console.Write("Input X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input Y: ");
        double y = double.Parse(Console.ReadLine());
        double d = Math.Sqrt(Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2));
        Console.WriteLine("Is the point inside K & outside of R?");
        if(d <= 1.5 && x < -1 || x > 5 && y < -1 || y > 1)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}
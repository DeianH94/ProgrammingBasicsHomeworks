using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Input X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input Y: ");
        double y = double.Parse(Console.ReadLine());
        double d = Math.Sqrt(x*x+y*y);
        Console.WriteLine("Is the point inside the circle?");
        if(d<=2)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}
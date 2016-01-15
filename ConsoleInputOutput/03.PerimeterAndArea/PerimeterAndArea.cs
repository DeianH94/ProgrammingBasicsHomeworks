using System;

class PerimeterAndArea
{
    static void Main()
    {
        Console.Write("Input circle radius: ");
        double r = double.Parse(Console.ReadLine());
        double c = 2 * Math.PI * r;
        double a = Math.PI * r * r;
        Console.WriteLine("The perimeter of the circle is: {0:0.##}", c);
        Console.WriteLine("The area of the circle is: {0:0.##}", a);
    }
}
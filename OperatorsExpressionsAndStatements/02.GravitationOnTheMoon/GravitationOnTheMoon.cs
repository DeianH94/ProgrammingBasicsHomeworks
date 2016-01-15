using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Input weight: ");
        double weight = double.Parse(Console.ReadLine());
        weight = (weight / 100) * 17;
        Console.WriteLine("Weight on the Moon: {0:0.###}", weight);
    }
}
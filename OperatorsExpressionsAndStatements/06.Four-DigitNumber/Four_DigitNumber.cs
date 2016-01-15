using System;

class Four_DigitNumber
{
    static void Main()
    {
        Console.WriteLine("Input number:");
        int num = int.Parse(Console.ReadLine());
        int first = (num / 1000) % 10;
        int second = (num / 100) % 10;
        int third = (num / 10) % 10;
        int fourth = num % 10;
        Console.WriteLine("Sum: {0}", first + second + third + fourth);
        Console.WriteLine("Reversed: " + fourth + third + second + first);
        Console.WriteLine("Last digit in front: " + fourth + first + second + third);
        Console.WriteLine("Second and third digits exchanged: " + first + third + second + fourth);
    }
}
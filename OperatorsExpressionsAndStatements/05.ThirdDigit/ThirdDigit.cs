using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Input number:");
        int num = int.Parse(Console.ReadLine());
        int thirdDigit = (num / 100) % 10;
        Console.WriteLine("Third digit 7?");
        if(thirdDigit == 7)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}
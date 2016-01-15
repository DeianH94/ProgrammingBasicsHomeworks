using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Input Number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Divided by 7 and 5?");
        if(n%5==0 && n%7==0)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}
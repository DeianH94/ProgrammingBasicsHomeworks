using System;

class Dates
{
    static void Main()
    {
        Console.WriteLine("Input first date:");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Input second date:");
        DateTime date2 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Days between:");
        Console.WriteLine((date2 - date1).TotalDays);
    }
}
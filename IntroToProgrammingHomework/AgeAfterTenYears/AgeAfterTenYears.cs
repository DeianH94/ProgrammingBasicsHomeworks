using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your bithday (xx.xx.xxxx format):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int age = now.Year - birthday.Year;
        Console.WriteLine("Now: " + age);
        age = age + 10;
        Console.WriteLine("After 10 years: " + age);
    }
}

using System;

class SumOfNumbers
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        double sum = 0;
        for(int i = 0; i < s.Length; i++)
        {
            double num = double.Parse(s[i]);
            sum = sum + num;
        }
        Console.WriteLine("Sum: {0:0.##}", sum);
    }
}
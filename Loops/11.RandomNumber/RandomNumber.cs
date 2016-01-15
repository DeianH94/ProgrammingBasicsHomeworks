using System;

class RandomNumber
{
    static void Main()
    {
        Random rnd = new Random();
        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Input max: ");
        int max = int.Parse(Console.ReadLine());
        if (min <= max)
        {
            for (int i = 0; i < n; i++)
            {
                int num = rnd.Next(min, max + 1);
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}
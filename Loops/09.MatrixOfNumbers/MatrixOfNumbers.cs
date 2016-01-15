using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Input int nuber: ");
        int num = int.Parse(Console.ReadLine());
        int start = 1;
        if (1 <= num && num <= 20)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(start + j);
                    if (start + j < 10)
                        Console.Write("  ");
                    else
                        Console.Write(" ");
                }
                start++;
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}
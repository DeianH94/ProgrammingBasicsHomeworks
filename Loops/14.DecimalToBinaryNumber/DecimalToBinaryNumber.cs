using System;
using System.Collections;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Input decimal num: ");
        long dec = long.Parse(Console.ReadLine());
        ArrayList ostatuk = new ArrayList();
        string result = null;
        if (dec == 0)
        {
            Console.WriteLine("Result = 0");
        }
        else
        {
            while (dec != 0)
            {
                ostatuk.Add(dec % 2);
                dec /= 2;
            }
            for (int j = ostatuk.Count - 1; j >= 0; j--)
            {
                result += ostatuk[j];
            }
            Console.WriteLine("Result = " + result);
        }
    }
}
using System;
using System.Collections;

class DecimalToHexadecimalNumber
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
                ostatuk.Add(dec % 16);
                dec /= 16;
            }
            for (int j = ostatuk.Count - 1; j >= 0; j--)
            {
                switch (Convert.ToInt32(ostatuk[j]))
                {
                    case 10: result += "A"; break;
                    case 11: result += "B"; break;
                    case 12: result += "C"; break;
                    case 13: result += "D"; break;
                    case 14: result += "E"; break;
                    case 15: result += "F"; break;
                    default: result += ostatuk[j]; ; break;
                }
            }
            Console.WriteLine("Result = " + result);
        }
    }
}
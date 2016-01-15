using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Input hexadecimal number:");
        string binary = Console.ReadLine();
        int[] arr = new int[binary.Length];
        int j = 0;
        long sum = 0;
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            switch(binary.Substring(j, 1))
            {
                case "A": arr[i] = 10; break;
                case "B": arr[i] = 11; break;
                case "C": arr[i] = 12; break;
                case "D": arr[i] = 13; break;
                case "E": arr[i] = 14; break;
                case "F": arr[i] = 15; break;
                default: arr[i] = int.Parse(binary.Substring(j, 1)); break;
            }
            j++;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i] * (long)Math.Pow(16, i);
        }
        Console.WriteLine("Decimal: " + sum);
    }
}
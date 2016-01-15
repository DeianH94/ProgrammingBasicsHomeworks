using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Input binary number:");
        string binary = Console.ReadLine();
        int[] arr = new int[binary.Length];
        int j = 0;
        long sum = 0;
        for(int i = binary.Length - 1; i >= 0; i--)
        {
            arr[i] = int.Parse(binary.Substring(j, 1));
            j++;
        }
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i] * (int)Math.Pow(2, i);
        }
        Console.WriteLine("Decimal: " + sum);
    }
}
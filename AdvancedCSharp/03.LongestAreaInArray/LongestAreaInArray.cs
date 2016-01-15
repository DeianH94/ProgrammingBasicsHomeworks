using System;

class LongestAreaInarr
{
    static void Main()
    {
        int longest = 0;
        string output = null;
        Console.Write("Input n:");
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        Console.WriteLine("Input " + n + " elements:");
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
            if (longest < count)
            {
                longest = count;
                output = arr[i];
            }
        }
        Console.WriteLine(longest);
        for (int k = 0; k < longest; k++)
        {
            Console.WriteLine(output);
        }
    }
}
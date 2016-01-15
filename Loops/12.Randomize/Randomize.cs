using System;

class Randomize
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            int j = rnd.Next(i);
            int k = arr[j];
            arr[j] = arr[i];
            arr[i] = k;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
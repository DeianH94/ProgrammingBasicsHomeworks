using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Input n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input " + n + " numbers:");
        int[] arr = new int[n];
        int temp;
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int write = 0; write < arr.Length; write++)
        {
            for (int sort = 0; sort < arr.Length - 1; sort++)
            {
                if (arr[sort] > arr[sort + 1])
                {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }
        }
        Console.WriteLine("Sorted:");
        foreach(int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}
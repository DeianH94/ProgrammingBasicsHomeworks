using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Input numbers separated by space:");
        string[] arr = Console.ReadLine().Split(' ');
        int even = 1, odd = 1;
        for(int i = 1; i <= arr.Length; i++)
        {
            if(i % 2 == 0)
            {
                even *= Convert.ToInt32(arr[i - 1]);
            }
            if(i % 2 != 0)
            {
                odd *= Convert.ToInt32(arr[i - 1]);
            }
        }
        if(even == odd)
        {
            Console.WriteLine("yes\nproduct = " + even);
        }
        else
        {
            Console.WriteLine("no\nodd_product = " + odd + "\neven_product = " + even);
        }
    }
}
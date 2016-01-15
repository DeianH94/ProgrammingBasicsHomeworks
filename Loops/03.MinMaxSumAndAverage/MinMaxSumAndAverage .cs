using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int biggest = 0, smallest = 0, sum = 0;
        double average = 0;
        for(int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if(i == 0)
            {
                biggest = arr[0];
                smallest = arr[0];
            }
            if(arr[i] > biggest)
            {
                biggest = arr[i];
            }
            if(arr[i] < smallest)
            {
                smallest = arr[i];
            }
            sum = sum + arr[i];
        }
        average = (double)sum / n;
        Console.WriteLine("Max: " + biggest);
        Console.WriteLine("Min: " + smallest);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: {0:F2}", average);
    }
}
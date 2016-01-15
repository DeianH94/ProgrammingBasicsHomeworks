using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Input the first sequence of numbers:");
        string[] arr1 = Console.ReadLine().Split(' ');
        Console.WriteLine("Input the second sequence of numbers:");
        string[] arr2 = Console.ReadLine().Split(' ');
        List<string> numList = new List<string>();
        for (int i = 0; i < arr1.Length; i++)
        {
            numList.Add(arr1[i]);
            if (i < arr2.Length)
            {
                numList.Add(arr2[i]);
            }
        }
        numList.Sort();
        numList = numList.Distinct().ToList();
        Console.WriteLine("Result:");
        foreach (var k in numList)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine();
    }
}
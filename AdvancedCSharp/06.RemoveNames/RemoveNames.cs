using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Input the first list whit numers:");
        string[] arr1 = Console.ReadLine().Split(' ');
        Console.WriteLine("Input the second list whit names:");
        string[] arr2 = Console.ReadLine().Split(' ');
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        for (int i = 0; i < arr1.Length; i++)
        {
            list1.Add(arr1[i]);
            if (i < arr2.Length)
            {
                list2.Add(arr2[i]);
            }
        }
        for (int i = 0; i < list2.Count; i++)
        {
            for (int j = 0; j < list1.Count; j++)
            {
                if (list1.Contains(list2[i]))
                {
                    list1.Remove(list2[i]);
                }
            }
        }
        Console.WriteLine("Result:");
        foreach (var k in list1)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.WriteLine("Input string:");
        string[] inputString = Console.ReadLine().Split(new char[] {' ', ',' });
        for (int i = 1; i < inputString.Length; i++)
        {
            if(inputString[i].StartsWith("http://") || inputString[i].StartsWith("www."))
            {
                if(inputString[i].EndsWith("."))
                {
                    inputString[i] = inputString[i].Remove(inputString[i].Length - 1);
                }
                Console.WriteLine(inputString[i]);
            }
        }
    }
}
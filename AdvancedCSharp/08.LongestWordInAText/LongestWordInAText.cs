using System;

class LongestWordInAText
{
    static void Main()
    {
        Console.WriteLine("Input string:");
        string[] inputString = Console.ReadLine().Split(new char[] { ' ', '.', ',' });
        string longestWord = inputString[0];
        for(int i = 1; i < inputString.Length; i++)
        {
            if(inputString[i].Length > longestWord.Length)
            {
                longestWord = inputString[i];
            }
        }
        longestWord = char.ToUpper(longestWord[0]) + longestWord.Substring(1);
        Console.WriteLine(longestWord);
    }
}
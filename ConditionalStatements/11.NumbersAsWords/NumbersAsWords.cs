using System;

class NumbersAsWords
{
    static void Main()
    {
        string[] words = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
        "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "nineteen", "twenty", "thirty", "fourty", "fifty", "sixty",
        "seventy", "eighty", "ninety", "hundred"};
        Console.WriteLine("Input number:");
        int num = int.Parse(Console.ReadLine());
        int first = (num / 100) % 10;
        int second = (num / 10) % 10;
        int third = num % 10;
        int temp = second * 10 + third;
        if(first > 0)
        {
            switch(first)
            {
                case 1: Console.Write(words[first - 1] + " hudred "); break;
                case 2: Console.Write(words[first - 1] + " hudred "); break;
                case 3: Console.Write(words[first - 1] + " hudred "); break;
                case 4: Console.Write(words[first - 1] + " hudred "); break;
                case 5: Console.Write(words[first - 1] + " hudred "); break;
                case 6: Console.Write(words[first - 1] + " hudred "); break;
                case 7: Console.Write(words[first - 1] + " hudred "); break;
                case 8: Console.Write(words[first - 1] + " hudred "); break;
                case 9: Console.Write(words[first - 1] + " hudred "); break;
            }
            if (second > 0)
            {
                Console.Write("and ");
            }
        }
        if(second > 1)
        {
            switch (second)
            {
                case 2: Console.Write(words[second + 16]+ " "); break;
                case 3: Console.Write(words[second + 16]+ " "); break;
                case 4: Console.Write(words[second + 16]+ " "); break;
                case 5: Console.Write(words[second + 16]+ " "); break;
                case 6: Console.Write(words[second + 16]+ " "); break;
                case 7: Console.Write(words[second + 16]+ " "); break;
                case 8: Console.Write(words[second + 16]+ " "); break;
                case 9: Console.Write(words[second + 16]+ " "); break;
            }
        }
        if (temp < 20 && temp >= 10)
        {
            switch (temp)
            {
                case 10: Console.WriteLine(words[temp - 1]); break;
                case 11: Console.WriteLine(words[temp - 1]); break;
                case 12: Console.WriteLine(words[temp - 1]); break;
                case 13: Console.WriteLine(words[temp - 1]); break;
                case 14: Console.WriteLine(words[temp - 1]); break;
                case 15: Console.WriteLine(words[temp - 1]); break;
                case 16: Console.WriteLine(words[temp - 1]); break;
                case 17: Console.WriteLine(words[temp - 1]); break;
                case 18: Console.WriteLine(words[temp - 1]); break;
                case 19: Console.WriteLine(words[temp - 1]); break;
            }
        }
        else if(third > 0)
        {
            switch(third)
            {
                case 1: Console.WriteLine(words[third - 1]); break;
                case 2: Console.WriteLine(words[third - 1]); break;
                case 3: Console.WriteLine(words[third - 1]); break;
                case 4: Console.WriteLine(words[third - 1]); break;
                case 5: Console.WriteLine(words[third - 1]); break;
                case 6: Console.WriteLine(words[third - 1]); break;
                case 7: Console.WriteLine(words[third - 1]); break;
                case 8: Console.WriteLine(words[third - 1]); break;
                case 9: Console.WriteLine(words[third - 1]); break;
            }
        }
        if ((first + second + third) == 0)
        {
            Console.WriteLine("zero");
        }
    }
}
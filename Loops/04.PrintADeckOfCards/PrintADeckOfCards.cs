using System;

class PrintADeckOfCards
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string n = "";
        for (int i = 0; i < 13; i++)
        {
            switch (i)
            {
                case 0: n = "2"; break;
                case 1: n = "3"; break;
                case 2: n = "4"; break;
                case 3: n = "5"; break;
                case 4: n = "6"; break;
                case 5: n = "7"; break;
                case 6: n = "8"; break;
                case 7: n = "9"; break;
                case 8: n = "10"; break;
                case 9: n = "J"; break;
                case 10: n = "Q"; break;
                case 11: n = "K"; break;
                case 12: n = "A"; break;
                default: Console.WriteLine("Error!"); break;
            }
            for(int j = 0; j < 4; j++)
            {
                switch(j)
                {
                    case 0: Console.Write(n + "\u2660"); break;
                    case 1: Console.Write(" " + n + "\u2663"); break;
                    case 2: Console.Write(" " + n + "\u2665"); break;
                    case 3: Console.WriteLine(" " + n + "\u2666"); break;
                    default: Console.WriteLine("Error!"); break;
                }
            }
        }
    }
}
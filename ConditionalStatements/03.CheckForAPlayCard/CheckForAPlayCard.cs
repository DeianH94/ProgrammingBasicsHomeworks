using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Input card sign: ");
        string card = Console.ReadLine();
        bool check = card == "J" || card == "Q" || card == "K" || card == "A";
        for(int i = 2; i < 11; i++)
        {
            if (card == Convert.ToString(i))
            {
                check = true;
            }
        }
        Console.WriteLine("Valid card sign?");
        if (check)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
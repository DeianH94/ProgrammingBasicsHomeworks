using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BaiIvanAdventures
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        double amountOfMoney = double.Parse(Console.ReadLine());
        double alcoholToBuy = double.Parse(Console.ReadLine());
        double alcoholHeCanBuy = 0;
        switch(dayOfWeek)
        {
            case 0: alcoholHeCanBuy = amountOfMoney / 25.0; break;
            case 1: alcoholHeCanBuy = amountOfMoney / 21.0; break;
            case 2: alcoholHeCanBuy = amountOfMoney / 14.0; break;
            case 3: alcoholHeCanBuy = amountOfMoney / 17.0; break;
            case 4: alcoholHeCanBuy = amountOfMoney / 45.0; break;
            case 5: alcoholHeCanBuy = amountOfMoney / 59.0; break;
            case 6: alcoholHeCanBuy = amountOfMoney / 42.0; break;
        }
        string condition;
        if(alcoholHeCanBuy > 1.5)
        {
            condition = "very drunk";
        }
        else if(alcoholHeCanBuy >= 1.0)
        {
            condition = "drunk";
        }
        else
        {
            condition = "sober";
        }
        if(alcoholToBuy < alcoholHeCanBuy)
        {
            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", condition, alcoholHeCanBuy - alcoholToBuy);
        }
        else if(alcoholToBuy == alcoholHeCanBuy)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
        }
        else
        {
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", condition, alcoholToBuy - alcoholHeCanBuy);
        }
    }
}
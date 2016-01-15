using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DreamItem
{
    static void Main(string[] args)
    {
        string[] info = Console.ReadLine().Split('\\');
        double eps = 0.001;
        int workDays = 0; ;
        if (info[0] == "Jan")
            workDays = 21;
        if (info[0] == "Feb")
            workDays = 18;
        if (info[0] == "March")
            workDays = 21;
        if (info[0] == "Apr")
            workDays = 20;
        if (info[0] == "May")
            workDays = 21;
        if (info[0] == "June")
            workDays = 20;
        if (info[0] == "July")
            workDays = 21;
        if (info[0] == "Aug")
            workDays = 21;
        if (info[0] == "Sept")
            workDays = 20;
        if (info[0] == "Oct")
            workDays = 21;
        if (info[0] == "Nov")
            workDays = 20;
        if (info[0] == "Dec")
            workDays = 21;
        double moneyPerHour = double.Parse(info[1]);
        int hoursPerDay = int.Parse(info[2]);
        double itemPrice = double.Parse(info[3]);
        double totalMoney = moneyPerHour * hoursPerDay * workDays;
        if(totalMoney > 700)
        {
            double bonus = 10 * (totalMoney / 100);
            totalMoney = totalMoney + bonus;
        }
        if(itemPrice > totalMoney)
            Console.WriteLine("Not enough money. {0:0.00} leva needed.", Math.Round(itemPrice - totalMoney, 4, MidpointRounding.AwayFromZero));
        else if(totalMoney > itemPrice)
            Console.WriteLine("Money left = {0:0.00} leva.", totalMoney - itemPrice);
        else if (Math.Abs(totalMoney - itemPrice) < eps)
            Console.WriteLine("Money left = 0.00 leva.");
    }
}
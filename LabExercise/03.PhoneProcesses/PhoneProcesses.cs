using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PhoneProcesses
{
    static void Main()
    {
        string batteryPower = Console.ReadLine();
        int startingBattery = int.Parse(batteryPower = batteryPower.Replace("%", null));
        string program = Console.ReadLine();
        int count = 0, countCompleted = 0;
        string[] test = new string[2];
        if (startingBattery <= 0)
        {
            Console.WriteLine("Phone Off");
        }
        else
        {
            while (!program.ToLower().Equals("end"))
            {
                test = program.Split('_');
                int batteryDrain = int.Parse(test[1] = test[1].Replace("%", null));
                count++;
                if(startingBattery > 15)
                {
                    countCompleted++;
                    startingBattery -= batteryDrain;
                }
                program = Console.ReadLine();
            }
            if(count == countCompleted && startingBattery > 0)
            {
                Console.WriteLine("Successful complete -> {0}%", startingBattery);
            }
            else if(startingBattery <= 0)
            {
                Console.WriteLine("Phone Off");
            }
            else
            {
                Console.WriteLine("Connect charger -> {0}%", startingBattery);
                Console.WriteLine("Programs left -> {0}", count - countCompleted);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class AniIsDrunk
{
    static void Main()
    {
        long numOfCabins = long.Parse(Console.ReadLine());
        string nextCommand = Console.ReadLine();
        long currentPosition = 0;
        long totatLenght = 0;
        while(nextCommand != "Found a free one!")
        {
            long numOfSteps = long.Parse(nextCommand);
            long oldPositon = currentPosition;
            currentPosition = (currentPosition + numOfSteps) % numOfCabins;
            long diff = currentPosition - oldPositon;
            totatLenght += Math.Abs(diff);
            if(diff > 0)
            {
                Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(diff));
            }
            else if(diff < 0)
            {
                Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(diff));
            }
            else
            {
                Console.WriteLine("Stay there, Ani.");
            }
            nextCommand = Console.ReadLine();
        }
        Console.WriteLine("Moved a total of {0} steps.", totatLenght);
    }
}
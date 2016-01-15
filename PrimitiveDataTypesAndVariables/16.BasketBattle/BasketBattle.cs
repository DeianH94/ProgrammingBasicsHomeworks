using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BasketBattle
{
    static int Main()
    {
        string first, isItSuccessfull;
        int numOfRounds, pointsToScore, i = 0, j, turn, pointsSimeon = 0, pointsNakov = 0;
        first = Console.ReadLine();
        if (String.Equals(first, "Simeon"))
            turn = 1;
        else
            turn = 2;
        numOfRounds = int.Parse(Console.ReadLine());
        for(j = 0;  j < numOfRounds; j++)
        {
            if(turn == 1)
            {
                i++;
                pointsToScore = int.Parse(Console.ReadLine());
                isItSuccessfull = Console.ReadLine();
                if(string.Equals(isItSuccessfull, "success"))
                {
                    pointsSimeon = pointsSimeon + pointsToScore;
                    if(pointsSimeon > 500)
                        pointsSimeon = pointsSimeon - pointsToScore;
                    if (pointsSimeon == 500)
                    {
                        Console.WriteLine("Simeon");
                        Console.WriteLine(i);
                        Console.WriteLine(pointsNakov);
                        return 0;
                    }
                }
                pointsToScore = int.Parse(Console.ReadLine());
                isItSuccessfull = Console.ReadLine();
                if (string.Equals(isItSuccessfull, "success"))
                {
                    pointsNakov = pointsNakov + pointsToScore;
                    if (pointsNakov > 500)
                        pointsNakov = pointsNakov - pointsToScore;
                    if (pointsNakov == 500)
                    {
                        Console.WriteLine("Nakov");
                        Console.WriteLine(i);
                        Console.WriteLine(pointsSimeon);
                        return 0;
                    }
                }
                turn = 2;
            }
            if (j < numOfRounds)
            {
                turn = 2;
            }
            if (turn == 2)
            {
                i++;
                pointsToScore = int.Parse(Console.ReadLine());
                isItSuccessfull = Console.ReadLine();
                if (string.Equals(isItSuccessfull, "success"))
                {
                    pointsNakov = pointsNakov + pointsToScore;
                    if (pointsNakov > 500)
                        pointsNakov = pointsNakov - pointsToScore;
                    if(pointsNakov == 500)
                    {
                        Console.WriteLine("Nakov");
                        Console.WriteLine(i);
                        Console.WriteLine(pointsSimeon);
                        return 0;
                    }
                }
                pointsToScore = int.Parse(Console.ReadLine());
                isItSuccessfull = Console.ReadLine();
                if (string.Equals(isItSuccessfull, "success"))
                {
                    pointsSimeon = pointsSimeon + pointsToScore;
                    if (pointsSimeon > 500)
                        pointsSimeon = pointsSimeon - pointsToScore;
                    if (pointsSimeon == 500)
                    {
                        Console.WriteLine("Simeon");
                        Console.WriteLine(i);
                        Console.WriteLine(pointsNakov);
                        return 0;
                    }
                }
                turn = 1;
            }
        }
        if(pointsNakov == pointsSimeon)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(pointsSimeon);
        }
        else if(pointsSimeon > pointsNakov)
        {
            Console.WriteLine("Simeon");
            Console.WriteLine(pointsSimeon - pointsNakov);
        }
        else if(pointsNakov > pointsSimeon)
        {
            Console.WriteLine("Nakov");
            Console.WriteLine(pointsNakov - pointsSimeon);
        }
        return 0;
    }
}
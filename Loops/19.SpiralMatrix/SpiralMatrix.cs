using System;

class Spiralarr
{
    static void Main()
    {
        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int x = 0;
        int y = 0;
        string direction = "right";
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (y > n - 1 || arr[x, y] != 0))
            {
                direction = "down";
                y--;
                x++;
            }
            if (direction == "down" && (x > n - 1 || arr[x, y] != 0))
            {
                direction = "left";
                x--;
                y--;
            }
            if (direction == "left" && (y < 0 || arr[x, y] != 0))
            {
                direction = "up";
                y++;
                x--;
            }
            if (direction == "up" && x < 0 || arr[x, y] != 0)
            {
                direction = "right";
                x++;
                y++;
            }
            arr[x, y] = i;
            switch (direction)
            {
                case "right": y++; break;
                case "up": x--; break;
                case "left": y--; break;
                case "down": x++; break;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}
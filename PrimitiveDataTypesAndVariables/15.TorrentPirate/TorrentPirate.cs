using System;

class TorrentPirate
{
    static void Main()
    {
        int d, p, w;
        double downloadTime, downloadPrice, cinemaPrice, numberOfMovies;
        Console.WriteLine("Input the total size of the download:");
        d = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the thicket price for one movie:");
        p = int.Parse(Console.ReadLine());
        Console.WriteLine("Input how much his wife spends in an hour");
        w = int.Parse(Console.ReadLine());
        downloadTime = (double)d / 2 / 60 / 60;
        downloadPrice = downloadTime * w;
        numberOfMovies = (double)d / 1500;
        cinemaPrice = numberOfMovies * p;
        if(downloadPrice <= cinemaPrice)
            Console.WriteLine("mall -> {0:0.00}lv", downloadPrice);
        else
            Console.WriteLine("cinema -> {0:0.00}lv", cinemaPrice);
    }
}

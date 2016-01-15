using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Inpute time:");
        string timeString = Console.ReadLine();
        CultureInfo culture = new CultureInfo("en-US");
        DateTimeStyles styles = DateTimeStyles.None;
        DateTime time;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        if (DateTime.TryParse(timeString, culture, styles, out time))
        {
            if (startTime <= time || time < endTime)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Non-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}
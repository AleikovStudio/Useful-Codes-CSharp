using System;


class DateTimeClass
{
    public static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine(today);

        DateTime tommorow = today.AddDays(1);
        Console.WriteLine(tommorow);
    }
}